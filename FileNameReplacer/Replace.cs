using System;
using System.IO;
using System.Threading;

namespace FileNameReplacer
{
    class Replace
    {
        public ReplaceJob[] Jobs = new ReplaceJob[] { };
        public Int16 Status = 0;
        public int[] TotalOK = new int[3] { 0, 0, 0 };

        public Action<ReplaceJob> OnFileRename;

        public void ReplaceFile()
        {
            for (int i = 0; i < Jobs.Length; i++)
            {
                Thread.Sleep(1);
                ReplaceJob job = Jobs[i];
                if (job.FromFullPath() == job.ToFullPath())
                {
                    job.Result = "I";
                    TotalOK[2]++;
                }
                else
                {
                    try
                    {
                        File.Move(job.FromFullPath(), job.ToFullPath()); //RENAME
                        job.Result = "O";
                        TotalOK[0]++;
                    }
                    catch (Exception ex)
                    {
                        job.Result = ex.Message;
                        TotalOK[1]++;
                    }
                }
                Jobs[i] = job;
                OnFileRename?.Invoke(job);
            }
        }
    }
}
