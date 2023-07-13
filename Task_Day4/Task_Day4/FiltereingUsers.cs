using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Day4
{
    public class FilteredUsers
    {
        List<Subcriber> subcribers = new List<Subcriber>();
        public List<Subcriber> filteredSubcribers = new List<Subcriber>();
        MyService service;
        object locker  = new object();
        public FilteredUsers(List<Subcriber> subcribers,MyService service)
        {
            this.subcribers = subcribers;
            this.service = service;
        }
        public void FilteringCheckByTasks()
        {
            List<Task> tasks = new List<Task>();
            foreach (Subcriber subcriber in subcribers)
            {
                Task task =  Task.Run(() =>
                {
                    try
                    {
                        subcriber.Check();
                        lock (locker)
                        {
                            filteredSubcribers.Add(subcriber);
                        }
                    }
                    catch (DateTimeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (IsInRoamingException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (IsServiceActiveException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (BalanceException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                });
                tasks.Add(task);
                Task.WaitAll(tasks.ToArray());
            }
        }
        public void ActivationByTask()
        {
            List<Task> tasks = new List<Task>();
            foreach (Subcriber sub in filteredSubcribers)
            {
                tasks.Add(Task.Run(() =>
                {
                    lock (locker)
                    {
                        sub.IsServiceActive = true;
                        sub.Balance = sub.Balance - service.Price;
                        sub.expirationDate = DateTime.Now.AddDays(30);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The service successfully activeted");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{service.Name} Patety hajoxutyamb aktivacvel e ev ayn aktiv e minchev {sub.expirationDate}");
                        Console.WriteLine($"Dzer yntacik hashivy kazmum e {sub.Balance} dr.");
                    }
                }));

                Task.WaitAll(tasks.ToArray());

            }
        }
        public void FilteringCheck()
        {
            List<Thread> threads = new List<Thread>();
            foreach (Subcriber subcriber in subcribers)
            {
                Thread thread = new Thread(() =>
                {
                    try
                    {
                        subcriber.Check();
                        lock (locker)
                        {
                            filteredSubcribers.Add(subcriber);
                        }
                    }
                    catch (DateTimeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (IsInRoamingException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (IsServiceActiveException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (BalanceException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                });
                threads.Add(thread);
                thread.Start();
            }
            foreach (Thread thread in threads)
                thread.Join();
        }
        public void Activation()
        {
            List<Thread> threads = new List<Thread>();
            foreach(Subcriber subcriber in filteredSubcribers)
            {
                Thread thread = new Thread(()=>
                {
                    lock (locker)
                    {
                        subcriber.IsServiceActive = true;
                        subcriber.Balance = subcriber.Balance - service.Price;
                        subcriber.expirationDate = DateTime.Now.AddDays(30); 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The service successfully activeted");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{service.Name} Patety hajoxutyamb aktivacvel e ev ayn aktiv e minchev {subcriber.expirationDate}");
                        Console.WriteLine($"Dzer yntacik hashivy kazmum e {subcriber.Balance} dr.");
                    }
                });
                threads.Add(thread);
                thread.Start();
            }
            foreach (Thread thread in threads)
                thread.Join();
        }
        
    }
}
