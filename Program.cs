using Algoritimos;

var array = new int[] {8, 10 ,5, 1, -5, 7, 9, 3};

Console.WriteLine("SumFor: [{0}]",string.Join(", ",SumTwoNumbers.SumFor(array, 8)));
Console.WriteLine("SumMemo: [{0}]", string.Join(", ", SumTwoNumbers.SumMemo(array, 8)));
Console.WriteLine("SumSlide: [{0}]", string.Join(", ", SumTwoNumbers.SumSlide(array, 8)));