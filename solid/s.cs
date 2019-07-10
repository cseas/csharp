using System;

// DataAccess class is only responsible for 
// database related operations
class DataAccess {
    public static void InsertData() {
        Console.WriteLine("Data inserted");
    }
}

// Logger class is only responsible for logging
// related operations
class Logger {
    public static void WriteLog() {
        Console.WriteLine("Time logged");
    }
}

public class Single {
    public static void Main(string[] args) {
        DataAccess.InsertData();
        Logger.WriteLog();
    }
}
