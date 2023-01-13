using static Sorting;

int size = 15;
var arr = size.CreateArray(0,10)
            .Show()
            .SortQuick(0, size - 1)
            .Show()
            ;