using Students;
using System.Collections.Generic;

public delegate bool FilterDelegate(Student student, string str);
public delegate bool CheckDelegate (Student student);
public delegate int SumDelegate (Student student);
public delegate decimal AverageDelegate(Student student);