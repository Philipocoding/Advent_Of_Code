using System;
using System.Collections.Generic;
using System.IO;

string filepath = "DayTwoData.txt";
List<string> numbersList = File.ReadAllLines(filepath).ToList();

int pass = 0;

foreach (string line in numbersList)
{
    string[] row = line.Split(' ');
    bool valid = true;
    bool? ascending = null;

    for (int z = 0; z < row.Length - 1; z++)
    {
        int j = Convert.ToInt32(row[z]);
        int jj = Convert.ToInt32(row[z + 1]);
        int diff = jj - j;

        if (diff == 0)
        {
            valid = false;
            break;
        }

        if (ascending == null)
        {
            if (diff > 0)
            {
                ascending = true;
            }
            else
            {
                ascending = false; 
            }
        }

        if (ascending == true) 
        {
            if (diff < 1 || diff > 3)
            {
                valid = false;
                break;
            }
        }
        else // If descending
        {
            if (diff > -1 || diff < -3)
            {
                valid = false;
                break;
            }
        }
    }

    if (valid)
    {
        pass++;
    }
}

Console.WriteLine(pass.ToString()); 
