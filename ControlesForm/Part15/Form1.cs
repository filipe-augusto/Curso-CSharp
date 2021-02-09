using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            #region parte 01 - Task
            //    Task part1 = Task.Factory.StartNew(new Action(() =>
            //    {
            //        Thread.Sleep(2000);
            //        progressBar2.Invoke(new Action(() => progressBar2.Value = 25));
            //    }));

            //    Task part2 = part1.ContinueWith((x)=>
            //    {
            //        Thread.Sleep(2000);
            //        progressBar2.Invoke(new Action(() => progressBar2.Value = 55));
            //    });
            //    Task part3 = part2.ContinueWith((x) =>
            //    {
            //        Thread.Sleep(2000);
            //        progressBar2.Invoke(new Action(() => progressBar2.Value = 75));
            //    });
            //    Task part4 = part3.ContinueWith((x) =>
            //    {
            //        Thread.Sleep(2000);
            //        progressBar2.Invoke(new Action(() => progressBar2.Value = 100));

            //    });
            #endregion

            List<Task> tasks = new List<Task>();
            tasks.Add(new Task(new Action(() =>
                {
                Thread.Sleep(1000);
                progressBar2.Invoke(new Action(() => progressBar2.PerformStep()));//avança um passoo
            })));
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(1000);
                progressBar2.Invoke(new Action(() => progressBar2.PerformStep()));//avança um passoo
            })));
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(500);
                progressBar2.Invoke(new Action(() => progressBar2.PerformStep()));//avança um passoo
            })));
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(1000);
                progressBar2.Invoke(new Action(() => progressBar2.PerformStep()));//avança um passoo
            })));
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(2000);
                progressBar2.Invoke(new Action(() => progressBar2.PerformStep()));//avança um passoo
            })));

            progressBar2.Maximum = tasks.Count;
            progressBar2.Step = 1;
            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Start();
            }

            }


        }
    }
