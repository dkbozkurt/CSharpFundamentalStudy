// Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

// Hashtable in C# (Hashmap)
// Use hashtables when working on massively scale collections.
// Notes: Indexing is not allowed in hastables [Thats why its more optimized]
//
// Ref: https://www.youtube.com/watch?v=s8YcbwVl-HI&ab_channel=RenaissanceCoders
namespace Hashtables_Hashmaps
{
    struct UserInfo
    {
        public int userId;
        public string userName;
        public UserInfo(int id,string name)
        {
            userId = id;
            userName = name;
        }
    }
    
    class Program
    {
        private static Hashtable userInfoHash;
        
        // For comperasing
        public static List<UserInfo> userInfoList;
        public static Stopwatch stopWatch;
        
        public static void Main()
        {
            userInfoHash = new Hashtable();
            
            userInfoList = new List<UserInfo>();
            stopWatch = new Stopwatch();

            //HashtableOps();

            HashtableVSList();

        }

        public static void HashtableOps()
        {
            // Adding
            for (int i = 0; i < 10; i++)
            {
                userInfoHash.Add(i, "User_" + i);
            }
            
            // Removing
            if (userInfoHash.ContainsKey(1))
            {
                userInfoHash.Remove(1);
            }
            
            // Setting
            if (userInfoHash.ContainsKey(2))
            {
                userInfoHash[2] = "replacementName";
            }
            
            // Looping
            foreach (DictionaryEntry entry in userInfoHash)
            {
                Console.WriteLine("Key: "+ entry.Key + " / Value: " + entry.Value);
            }
        }
        
        public static void HashtableVSList()
        {
            // Adding
            for (int i = 0; i < 4000000; i++)
            {
                userInfoHash.Add(i, "User_" + i);
                userInfoList.Add(new UserInfo(i,"User_"+i));
            }
            
            // Looping
            // foreach (DictionaryEntry entry in userInfoHash)
            // {
            //     Console.WriteLine("Key: "+ entry.Key + " / Value: " + entry.Value);
            // }
            
            // Access
            Random randomUserGenerator = new Random();
            int randomUser = -1;
            
            stopWatch.Start();
            float startTime = 0;
            float endTime = 0;
            float deltaTime = 0;

            int cycles = 5;
            int cycle = 0;
            string userName = string.Empty;

            while (cycle < cycles)
            {
                randomUser = randomUserGenerator.Next(3000000, 4000000);

                startTime = stopWatch.ElapsedMilliseconds;
                // Access from list
                userName = GetUserFromList(randomUser);
                endTime = stopWatch.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                Console.WriteLine("Time taken to retrieve " + userName + " from list took " + string.Format("{0:0.##}",deltaTime)+ "ms");

                startTime = stopWatch.ElapsedMilliseconds;
                // Access from hashtable
                userName = (string) userInfoHash[randomUser];
                endTime = stopWatch.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                
                Console.WriteLine("Time taken to retrieve " + userName + " from hash took " + string.Format("{0:0.##}",deltaTime)+ "ms");

                cycle++;

            }


        }

        public static string GetUserFromList(int userId)
        {
            for (int i = 0; i < userInfoList.Count; i++)
            {
                if(userInfoList[i].userId == userId) return userInfoList[i].userName;
            }
            return string.Empty;
        }
    }
}

