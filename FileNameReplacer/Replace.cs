using System;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.FileIO;

namespace FileNameReplacer
{
    class Replace
    {
        public ReplaceJob[] Jobs = new ReplaceJob[] { };
        public Int16 Status = 0;
        public Int16 FileAction = 0;
        public bool Emu = true;
        public int SleepTime = 1;
        public int[] TotalOK = new int[3] { 0, 0, 0 };
        public bool run = false;

        public Action<ReplaceJob> OnFileRename;

        public void ReplaceFile()
        {
            for (int i = 0; i < Jobs.Length; i++)
            {
                if (!run) return;
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
                        if (FileAction == 0)
                        {
                            Console.WriteLine((job.IsDir ? "D " : "F ") + job.FromFullPath() + " -> " + job.ToFullPath());
                            if (!Emu)
                            {
                                if (job.IsDir)
                                {
                                    Directory.Move(job.FromFullPath(), job.ToFullPath());
                                }
                                else
                                {
                                    File.Move(job.FromFullPath(), job.ToFullPath());
                                }
                            }
                            job.Result = "O";
                            TotalOK[0]++;
                        }
                        else if (FileAction == 1 || FileAction == 2)
                        {
                            Console.WriteLine((job.IsDir ? "D " : "F ") + job.FromFullPath() + " -> " + (FileAction == 1 ? "RecycleBin" : "X"));
                            if (!Emu)
                            {
                                if (job.IsDir)
                                {
                                    if (FileAction == 1)
                                    {
                                        FileSystem.DeleteDirectory(job.FromFullPath(), UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                                    }
                                    else
                                    {
                                        Directory.Delete(job.FromFullPath(), true);
                                    }
                                }
                                else
                                {
                                    if (FileAction == 1)
                                    {
                                        FileSystem.DeleteFile(job.FromFullPath(), UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                                    }
                                    else
                                    {
                                        File.Delete(job.FromFullPath());
                                    }
                                }
                            }
                            job.Result = FileAction == 1 ? "B" : "R";
                            TotalOK[0]++;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        job.Result = ex.Message;
                        TotalOK[1]++;
                    }
                }
                Jobs[i] = job;
                OnFileRename?.Invoke(job);
                Thread.Sleep(SleepTime);
            }
        }
    }
}
