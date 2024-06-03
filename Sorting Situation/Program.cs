using Sorting_Situation;
using System.Data;
using System;
using System.Reflection.Metadata;
using System.Collections;
using System.Runtime.InteropServices;
class shootingRange
{
    static void Main()
    {
        //Weapon pistol = new Weapon(9, 45, "Pistol");
        //Weapon rifle = new Weapon(6, 56, "Rifle");
        //Weapon minigun = new Weapon(1, 100, "Minigun");
        //Weapon crowwbow = new Weapon(5, 60, "CrossBow");

        //Weapon deagle = new Weapon(13, 60, "Deagle");
        //Weapon knife = new Weapon(100, 30, "Knife");
       
        //List<Weapon> stash2 = new List<Weapon>();
        //List<Weapon> stash = new List<Weapon>();
        //Dictionary<string, int> gunsMap = new Dictionary<string, int>();
        
        //    stash.Add(pistol);
        //    stash.Add(rifle);
        //    stash.Add(minigun);
        //    stash.Add(crowwbow);    

        //    stash2.Add(deagle);
        //    stash2.Add(knife);
        //    stash2.Add(minigun);
        //    stash2.Add(crowwbow);

        //Console.WriteLine("==B4 sort:");
        //printGuns(stash);
        //Console.WriteLine("==After sort:");
        ////bubbleSort(stash);
        //quickSort(stash, 0, stash.Count - 1);
        //printGuns(stash);

        //int sameGunsForStash2 = stash.Intersect(stash2).Count();

        //Console.WriteLine($" There are {sameGunsForStash2} of same guns for stash2");

        BinarySearchTree tree = new BinarySearchTree();
        tree.insert(new Node(5));
        tree.insert(new Node(1));
        tree.insert(new Node(2));
        tree.insert(new Node(5));
        tree.insert(new Node(7));
        tree.insert(new Node(9));
        tree.insert(new Node(9));
        tree.insert(new Node(4));
        tree.insert(new Node(0));
        tree.insert(new Node(3));
        tree.remove((1));
        tree.display();
        Console.WriteLine(  "SEARCH RESULT:");
        Console.WriteLine( tree.search(6));
    }
    static void bubbleSort(List<Weapon> stash)
    {
        for(int i = 0; i < stash.Count; i++) 
        {
            for(int j =0; j < stash.Count - 1; j++) 
            {
                if (stash[i].Damage < stash[j].Damage)
                    swap(stash, i, j);
            }
        }
    }
    static void swap(List <Weapon>stash, int i, int j)
    {
        Weapon temp = stash[i];
        stash[i] = stash[j];
        stash[j] = temp;
    }
    static void quickSort(List<Weapon> stash, int start, int end) 
    {
        if (end <= start) return; // base

        int pivot = partition(stash, start, end);
        quickSort(stash, start, pivot - 1);
        quickSort(stash, pivot + 1, end);

    }
    static int partition(List<Weapon> stash, int start, int end)
    {
        Weapon pivot = stash[end];
        int i = start - 1;

        for(int j = start; j <= end - 1; j++)
        {
            if (stash[j].Damage < pivot.Damage)
            {
                i++;
                swap(stash, i, j);
            }
        }
        i++;
        swap(stash, i, end);
        return i;
    }
    static void printGuns(List<Weapon> stash)
    {
        foreach (Weapon weapon in stash)
        {
            weapon.PrintWeapon();
        }
    }

}