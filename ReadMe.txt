
Instruction:

1. paste your unsorted-names-list.txt  inside NameSorterApp/bin/Debug/netcoreapp2.0/
2. If you intend to run the program from visual studio, without passign args[], thats fine,
   it will work. But in that case the input file name is needed to be "unsorted-names-list.txt".
   Otherwise, you will get a "File does not exist error message.".
   
   Or,
   
   You can pass the unsorted file names from command line arguments. The argument length
   need to be 1. Otherwise, it will run the sorting using default settings.

3. Enjoy the sorted list inside NameSorterApp/bin/Debug/netcoreapp2.0/ as "sorted-names-list.txt"


Additional Information:

- A xUnit Test project has been added to test the functionality. The Name sorter application
  Pass the test.
- Travis CI has been used (pretty basic) to implement the build pipeline


