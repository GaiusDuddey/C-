// *******************************WEEK -1.2**************************
// Console.WriteLine("Enter the speed of the object (m/s):");
// decimal v=Convert.ToDecimal(Console.ReadLine());
// Console.WriteLine("Enter the time duration (s):");
// decimal t=Convert.ToDecimal(Console.ReadLine());
// if (v<=0){
//   Console.WriteLine("Invalid input: Speed must be greater than zero.");
//   return;
// }
// if (t<=0){
//   Console.WriteLine("Invalid input: Time must be greater than zero.");
//   return;
// }
// decimal d=v*t;
// Console.WriteLine("Distance traveled:"+d+"meters");
// ******************************************WEEK-1.3************************************************************
// Console.WriteLine("Enter the Number:");
// int n=Convert.ToInt32((Console.ReadLine()));
// double cuberoot=Math.Pow(n,1.0/3.0);
// Console.WriteLine(cuberoot);
// ******************************************WEEK-1.4************************************************************
// Random random=new Random();
// Console.WriteLine("Enter the number of random numbers to generate:");
// if (!int.TryParse(Console.ReadLine(), out int count) || count
// <= 0)
// {
// Console.WriteLine("Invalid input: Please enter a positive integer.");
// return;
// }

// Console.WriteLine("Enter the minimum value of the range:");
// if (!int.TryParse(Console.ReadLine(), out int min))
// {
// Console.WriteLine("Invalid input: Please enter a valid number.");
// return;
// }

// Console.WriteLine("Enter the maximum value of the range:");
// if (!int.TryParse(Console.ReadLine(), out int max) ||
// max <= min)
// {
// Console.WriteLine("Invalid input: Maximum value must be greater than minimum value.");
// return;
// }
// Console.WriteLine("Generated Random Numbers:");
// int randcount=1;
// while (randcount<=count){
//   int randnumber=random.Next(min,max+1);
//   Console.WriteLine(randnumber);
//   randcount+=1;
// }
// ******************************************WEEK-1.5************************************************************
// int? intVal1=null;
// int? intVal1=786;
// float? floatval1=3.14F;
// float? floatval2=new float?();
// bool? boolval=new bool?();
// Console.WriteLine("Nullable Integers : {0},{1}", intVal1, intVal2);
// Console.WriteLine("Nullable Floats : {0}, {1}", floatVal1, floatVal2);
// Console.WriteLine("Nullable boolean: {0}",boolval);
// ******************************************WEEK-1.6************************************************************
// Console.WriteLine("Enter the value of n:");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the value of r:");
// int r=Convert.ToInt32(Console.ReadLine());
// int nfact=1;
// int rfact=1;
// if(r<n){
// for(int i=2;i<=n;i++){
//   nfact*=i;
// }
// for(int j=2;j<=(n-r);j++){
//   rfact*=j;
// }
// float res=(nfact/rfact);
// Console.WriteLine("Number of permutations:"+res);
// }
// else{
//   Console.WriteLine("Error: r cannot be greater than n.");  
// }
// ******************************************WEEK-1.7************************************************************
// ******************************************WEEK-1.8************************************************************
// Console.WriteLine("Enter the first integer:");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the second integer:");
// int num2=Convert.ToInt32(Console.ReadLine());
// int andResult=num1 & num2;
// int orResult=num1 | num2;
// // int xorResult = num1 ˆ num2;
// // int notResult = ˜num1;
// int leftShiftResult = num1 << 2;
// int rightShiftResult = num1 >> 2;
// Console.WriteLine($"Bitwise AND ({num1} & {num2})={andResult}");
// Console.WriteLine($"Bitwise OR ({num1} | {num2}) = {orResult}");
// // Console.WriteLine($"Bitwise XOR ({num1} ˆ {num2}) = {xorResult}");
// // Console.WriteLine($"Bitwise NOT (˜{num1}) = {notResult}");
// Console.WriteLine($"Left Shift ({num1} << 2) = {leftShiftResult}");
// Console.WriteLine($"Right Shift ({num1} >> 2) = {rightShiftResult}");
// ******************************************WEEK-1.9************************************************************
// Console.WriteLine("Enter a number to find its square root:");
// int squareroot_num=Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Enter a number to find its absolute value:");
// // int absolute_num=Convert.ToInt32(Console.ReadLine());
// decimal sqr_res=(decimal)Math.Ceiling(Math.Pow(squareroot_num, 1.0/2.0));
// Console.WriteLine(sqr_res);
// double abs_res=FindAbsoluteValue(absolute_num);
// Console.WriteLine(abs_res);
// ******************************************WEEK-2.1************************************************************
// int n=Convert.ToInt32(Console.ReadLine());
// List<string> list=new List<string>();
// if (n>0){
//   if(n%2==0){
//     for(int i=1;i<=n;i++){
//       list.Add(new string('>',i));
//     }
//     for(int i=n-1;i>=1;i--){
//       list.Add(new string('>',i));
//     }
//   }
//   if(n%2!=0){
//     for(int i=1;i<=n;i++){
//       list.Add(new string('>',i));
//     }
//     for(int i=n-1;i>=1;i--){
//       list.Add(new string('>',i));
//     }
//   }
//   // convert the list into an array
//   string[] arr=list.ToArray();
//   Console.WriteLine(String.Join(",",arr));
// }
// ******************************************WEEK-2.2************************************************************
// using System;
// class Program{
//   public static string Overtime(double[] workdetails){
//     double start=workdetails[0];
//     double end=workdetails[1];
//     double hrrate=workdetails[2];
//     double over=workdetails[3];

//     double regend=17.0;
//     double total=0.0;

//     if(end<=regend){
//       total=(end-start)*hrrate;
//     }
//     else if (start >= regend)
//         {
//             total = (end - start) * hrrate * over;
//         }
//         else
//         {
//             double regularHours = regend - start;
//             total += regularHours * hrrate;

//             double overtimeHours = end - regend;
//             total += overtimeHours * hrrate * over;
//         }
//         return $"${total:F2}";
//   }
// }
// ******************************************WEEK-2.3************************************************************
// string name=Console.ReadLine();
// int n=int.Parse(Console.ReadLine());
// string names=Console.ReadLine();
// Console.WriteLine(License(name,n,names));

// static int License(string name,int n,string names){
//   string[] Names=input.Split(' ');
//   List<string> newnames=new List<string>(Names);
//   newnames.Add(name);
//   newnames.Sort();

//   int grp=((newnames.IndexOf(name)/n)+1);
//   int time=grp*20;

//   return time;
// }
// ******************************************WEEK-2.4************************************************************
// using System;
// class Program{
//   public static int League(int[] val){
//     int played=val[0];
//     int won=val[1];
//     int drawn=val[2];
//     int lost=val[3];
//     int diff=val[4];
//   }
// }
// ******************************************WEEK-2.5************************************************************
// using System.Globalization;

// Console.WriteLine("Enter the year: ");
// int yr = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Enter the month: ");
// int mon = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Enter the date: ");
// int date = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Enter the language: ");
// string lang = Console.ReadLine();

// CultureInfo ci = new CultureInfo(Checklang(lang));
// DateTime dt = new DateTime(yr,mon,date);
// WeekDay(dt,ci);

// static void WeekDay(DateTime dt, CultureInfo ci)
// {
//     Console.WriteLine("The day is "+dt.ToString("dddd",ci)); 
// }

// static string Checklang(string lang)
// {
//      switch (lang)
//      {
//         case "english":
//             return "en-En";
//         case "spanish":
//             return "es-Es";
//         case "dutch":
//             return "nl-NL";
//         case "telugu":
//             return "te-IN";
//         case "hindi":
//             return "hi-IN";
//         case "italy":
//             return "it-IT";
//         case "japanese":
//             return "ja-JP";
//      }
//      return "error";
// }
// ******************************************WEEK-3.4************************************************************
// Console.WriteLine("Enter the movement instructions");
// string inpt = Console.ReadLine();
// if(inpt.Equals("")){
//     Console.WriteLine("No value entered!");
// }
// string[] instructions = inpt.Split(", ");
// int vertical = 0;
// int horizontal = 0;
// Dictionary<string, int> movementDict = new Dictionary<string, int>();
// foreach (string instruction in instructions)
// {
//     string[] parts = instruction.Split(" ");
//     string direction = parts[0];
//     int movement = int.Parse(parts[1].Trim());
//     movementDict.Add(direction, movement);
// }

// foreach (KeyValuePair<string, int> entry in movementDict)
// {

//     switch (entry.Key)
//     {
//         case "up":
//             vertical += entry.Value;
//             break;
//         case "down":
//             vertical -= entry.Value;
//             break;
//         case "left":
//             horizontal -= entry.Value;
//             break;
//         case "right":
//             horizontal += entry.Value;
//             break;
//         default:
//             break;
//     }

// }

// Console.Write(vertical > 0 ? $"up: {vertical} " : vertical < 0 ? $"down: {-vertical} " : "");
// Console.Write(horizontal > 0 ? $"right: {horizontal}" : horizontal < 0 ? $"left: {-horizontal}" : "");
// ******************************************WEEK-3.5************************************************************
// public class five
// {
//     public static void Main(string[] args)
//     {
//         string input = Console.ReadLine();
//         Console.WriteLine(TrueAlphabetic(input));
//     }
//     public static string TrueAlphabetic(string sentence)
//     {
//         // Remove spaces and sort all characters
//         var sortedChars = new string(sentence.Replace(" ", "").OrderBy(c => c).ToArray());
        
//         // Split the sentence into words
//         var words = sentence.Split(' ');
        
//         // Initialize variables to keep track of the position in the sorted characters
//         int index = 0;
//         string result = "";

//         // Iterate through each word
//         foreach (var word in words)
//         {
//             // Take the next 'word.Length' characters from sortedChars
//             result += new string(sortedChars.Skip(index).Take(word.Length).ToArray()) + " ";
//             index += word.Length;
//         }

//         // Trim the trailing space and return the result
//         return result.Trim();
//     }
// }
// ******************************************WEEK-3.6************************************************************
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter first Word: ");
//         string first = Console.ReadLine();
//         Console.WriteLine("Enter second Word: ");
//         string second = Console.ReadLine();


//         Console.WriteLine("Longest common ending: " + LongestCommonEnding(first, second));
//     }

//     public static string LongestCommonEnding(string str1, string str2)
//     {
//         int minLength = Math.Min(str1.Length, str2.Length);
//         string longestEnding = "";
//         for (int i = minLength; i >= 1; i--)
//         {
//             string ending = str1.Substring(str1.Length - i, i);
//             if (str2.EndsWith(ending))
//             {
//                 longestEnding = ending;
//                 break;
//             }
//         }
//         return longestEnding;
//     }
// }
// ******************************************WEEK-3.7************************************************************
// Console.WriteLine("Enter a word: ");
// string inpt = Console.ReadLine();

// Dictionary<char, int> charCount = new Dictionary<char, int>();

// foreach (char c in inpt)
// {
    
//     if (charCount.ContainsKey(c))
//     {
//         charCount[c]++;
//     }
//     else
//     {
//         charCount[c] = 1;
//     }
// }

// int duplicateCount = charCount.Values.Count(count => count > 1);
// Console.WriteLine(duplicateCount);
// // ******************************************WEEK-3.8************************************************************
// public class eight
// {
//     public static void M(string[] args)
//     {
//         string input = Console.ReadLine();
//         Console.WriteLine(DuplicateCount(input));
//     }

//     public static int DuplicateCount(string input)
//     {
//         return input
//             .Where(c => char.IsLetterOrDigit(c))
//             .GroupBy(c => c)
//             .Count(g => g.Count() > 1);
//     }
// }
// // ******************************************WEEK-3.9************************************************************
// using System.Runtime.InteropServices.JavaScript;

// public class nine
// {
//     public static void M(string[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
//         Console.WriteLine(isUban(n));
//     }

//     public static bool isUban(int n)
//     {
//         string englishname = NumberToWords(n);
//         return !englishname.Contains("u", StringComparison.OrdinalIgnoreCase);
//     }
    
//     private static string NumberToWords(int number)
//     {
//         if (number == 0)
//             return "zero";

//         if (number < 0)
//             return "minus " + NumberToWords(Math.Abs(number));

//         string words = "";

//         if ((number / 1000000) > 0)
//         {
//             words += NumberToWords(number / 1000000) + " million ";
//             number %= 1000000;
//         }

//         if ((number / 1000) > 0)
//         {
//             words += NumberToWords(number / 1000) + " thousand ";
//             number %= 1000;
//         }

//         if ((number / 100) > 0)
//         {
//             words += NumberToWords(number / 100) + " hundred ";
//             number %= 100;
//         }

//         if (number > 0)
//         {
//             if (words != "")
//                 words += "and ";

//             var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
//             var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

//             if (number < 20)
//                 words += unitsMap[number];
//             else
//             {
//                 words += tensMap[number / 10];
//                 if ((number % 10) > 0)
//                     words += "-" + unitsMap[number % 10];
//             }
//         }
//         return words.Trim();
//     }
// }
//******************************************WEEK-4.1************************************************************
using System;
public class Program{
    public static void Main(){
        Console.WriteLine(ClimbStairs(2));
        Console.WriteLine(ClimbStairs(3));
        Console.WriteLine(ClimbStairs(5));
        Console.ReadKey();
    }
    public static int ClimbStairs(int n){
        // if(n==1)
        // return 1;
        // if(n==2)
        // return 2;
        // int[] dp= new int[n+1];
        // dp[1]=1;
        // dp[2]=2;
        // for(int i=3;i<=n;i++){
        //     dp[i]=dp[i-1]+dp[i-2];
        // }
        // return dp[n];
        if(n==1)
        return 1;
        if(n==2)
        return 2;
        int[] dp=new int[n+1];
        dp[1]=1;
        dp[2]=2;
        for(int i=3;i<=n;i++){
          dp[i]=dp[i-1]+dp[i-2];
        }
        return dp[n];
    }
}
//******************************************WEEK-4.2************************************************************
