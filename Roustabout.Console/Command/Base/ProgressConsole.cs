using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tharga.Toolkit.Console.Command.Base
{
    public class ProgressConsole : IDisposable
    {
        private CancellationToken cancelToken;
        private IConsole console;
        private bool indeterminate;
        private string name;
        private int _cursorTop;
        private ConsoleColor _startColor;
        private CancellationTokenSource tokenSource;
        private Task _indTask;
        private DateTime _starttime;
        private Stopwatch _sw;

        public ProgressConsole(string name, IConsole console, bool indeterminate)
        {
            this.name = name;
            this.console = console;
            this._startColor = console.ForegroundColor;
            console.ForegroundColor = ConsoleColor.Red;
            this.indeterminate = indeterminate;
            //console.WriteLine(name);
            this._cursorTop = console.CursorTop;
            if (!indeterminate)
            {
                console.SetCursorPosition(0, _cursorTop);
                console.Write("[{0} (0%)>", new string[] { name });
                console.SetCursorPosition(console.BufferWidth -1, _cursorTop);
                console.Write("]");

                _sw = Stopwatch.StartNew();
                //ReportProgress(0, 1);
            }
            else
            {
                console.SetCursorPosition(0, _cursorTop);
                console.Write("[{0} >", new string[] { name });
                console.SetCursorPosition(console.BufferWidth - 1, _cursorTop);
                console.Write("]");
                this.cancelToken = new System.Threading.CancellationToken();

                this.tokenSource = new CancellationTokenSource();
                cancelToken = tokenSource.Token;
                _indTask =  Task.Run(() => RunIND(cancelToken), cancelToken);

            }


        }

        private void RunIND(CancellationToken token)
        {
            
            while (true)
            {

                for (int x = 8; x > 0; x--)
                {

                    var spinchar = "";

                    switch (x)
                    {
                        case 1:
                            spinchar = "/";
                            break;
                        case 2:
                            spinchar = "-";
                            break;
                        case 3:
                            spinchar = "\\";
                            break;
                        case 4:
                            spinchar = "|";
                            break;
                        case 5:
                            spinchar = "/";
                            break;
                        case 6:
                            spinchar = "-";
                            break;
                        case 7:
                            spinchar = "\\";
                            break;
                        case 8:
                            spinchar = "|";
                            break;
                        default:
                            break;
                    }


                    var length = (console.BufferWidth - 3) - name.Length;

                    console.SetCursorPosition(name.Length + 2, _cursorTop);


                    var sb = "";
                    for (int i = 0; sb.Length < length; i++)
                    {
                        if (token.IsCancellationRequested)
                        {
                            return;
                        }

                        if (i % 3  == 0)
                        {
                            sb += spinchar;
                        }
                        else
                        {
                            sb += " ";
                        }
                    }
                    console.Write(sb);
                    Thread.Sleep(90);
                }

            }
        }

        public void Dispose()
        {
            lock (console)
            {
                if (!indeterminate)
                {
                    console.ForegroundColor = ConsoleColor.Green;
                    console.SetCursorPosition(0, _cursorTop);
                    console.Write("[{0} (0%)>", new string[] { name });
                    console.SetCursorPosition(console.BufferWidth - 1, _cursorTop);
                    console.Write("]");
                    _sw.Stop();

                    ReportProgress(100);
                }
                else
                {
                    console.ForegroundColor = ConsoleColor.Green;
                    console.SetCursorPosition(0, _cursorTop);
                    console.Write("[{0}", new string[] { name });


                    var length = (console.BufferWidth - 2) - name.Length;

                    console.SetCursorPosition(name.Length + 2, _cursorTop);



                    console.Write(new String('=', length));
                    console.SetCursorPosition(console.BufferWidth - 1, _cursorTop);
                    console.Write("]");

                    tokenSource.Cancel();
                    Task.WaitAll(new Task[] { _indTask });
                    console.SetCursorPosition(0, _cursorTop + 1);
                }

                console.ForegroundColor = this._startColor;
                console.SetCursorPosition(0, _cursorTop + 1);
            }
        }



        internal void ReportProgress(double progress)
        {
            lock (console)
            {

                // time left

                var left = " " + _sw.GetEta((int)progress, 100).ToPrettyFormat() + "left";
                if(progress == 100)
                {
                    left = "";
                }

                var length = (console.BufferWidth - 2) - name.Length;

                console.SetCursorPosition(name.Length + 2, _cursorTop);
                var percent = string.Format("({0}%{1})", Math.Round(progress, 0), left);
                console.Write(percent);

                length = length - percent.Length;

                var count = (int)Math.Floor((progress / 100) * length);
                console.Write(new String('=', count) + ">");
                console.SetCursorPosition(console.BufferWidth - 1, _cursorTop);
                console.Write("]");
            }


            //var left = current * length;
            //var count = (int)left / total;

            // Write Frame


        }


        internal void ReportProgress(int current, int total)
        {

            ReportProgress(((double)current / (double)total) * 100.0);


            //var length = (console.BufferWidth - 2);

            //var left = current * length;
            //var count = (int)left / total;

            // Write Frame
        

        }
    }

    static class StopWatchUtils
    {

        public static string ToPrettyFormat(this TimeSpan span)
        {

            if (span == TimeSpan.Zero) return "Unknown Time";

            var sb = new StringBuilder();
            if (span.Days > 0)
                sb.AppendFormat("{0} day{1} ", span.Days, span.Days > 1 ? "s" : String.Empty);
            if (span.Hours > 0)
                sb.AppendFormat("{0} hour{1} ", span.Hours, span.Hours > 1 ? "s" : String.Empty);
            if (span.Minutes > 0)
                sb.AppendFormat("{0} minute{1} ", span.Minutes, span.Minutes > 1 ? "s" : String.Empty);
            if (span.Seconds > 0)
                sb.AppendFormat("{0} second{1} ", span.Seconds, span.Seconds > 1 ? "s" : String.Empty);
           
            if(span.TotalSeconds < 1)
            {
                return "<1 second ";
            }


            return sb.ToString();

        }

        /// <summary>
        /// Gets estimated time on compleation. 
        /// </summary>
        /// <param name="sw"></param>
        /// <param name="counter"></param>
        /// <param name="counterGoal"></param>
        /// <returns></returns>
        public static TimeSpan GetEta(this Stopwatch sw, int counter, int counterGoal)
        {
            /* this is based off of:
             * (TimeTaken / linesProcessed) * linesLeft=timeLeft
             * so we have
             * (10/100) * 200 = 20 Seconds now 10 seconds go past
             * (20/100) * 200 = 40 Seconds left now 10 more seconds and we process 100 more lines
             * (30/200) * 100 = 15 Seconds and now we all see why the copy file dialog jumps from 3 hours to 30 minutes :-)
             * 
             * pulled from http://stackoverflow.com/questions/473355/calculate-time-remaining/473369#473369
             */

            try {
                float elapsedMin = ((float)sw.ElapsedMilliseconds / 1000) / 60;
                float minLeft = (elapsedMin / counter) * (counterGoal - counter); //see comment a
                if (float.IsNaN(minLeft))
                {
                    minLeft = 0;
                }
                TimeSpan ret = TimeSpan.FromMinutes(minLeft);
                return ret;
            }
            catch
            {

                return TimeSpan.Zero;
            }
        }
    }
}