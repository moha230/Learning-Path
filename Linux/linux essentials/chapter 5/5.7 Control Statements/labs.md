# 5.2 Files and Directories

The prompt tells you that you are user sysadmin; the host or computer you are using: localhost; and the directory where you are at: ~, which represents your home directory.

ls list files in directory 
-l option used to list files in long format 


not that directories are considered a type of file in the linux file system 

using the ls command and option key -l and its argument we can see what is contained in that directory 

example `ls -l /home`

who am i command is used to search for the user of the system 

uname command stand for unix name its used to display system infromation about the operating system and hardware its running on 



-a: Display all available system information (kernel name, nodename, kernel release, kernel version, machine, processor, hardware platform, and operating system).
-s: Show the kernel name (default behavior).
-n: Show the network node hostname.
-r: Show the kernel release.
-v: Show the kernel version.
-m: Show the machine hardware name (architecture).
-p: Show the processor type (if available).
-i: Show the hardware platform (if available).
-o: Show the operating system name.`

`

# 5.3 Command History

The history command can take number as parameters 

To execute a command again, type the exclamation point and the history list number. For example, to execute the 9th command in your history list, you would execute the following:

# 5.4 Shell Variables

metacharacters

Metacharacters are special characters in computing, particularly in the context of command-line interfaces, programming, and regular expressions, that have specific meanings or functions beyond their literal interpretation. They are often used to perform operations or manipulate strings, control flow, or handle patterns. Below is an overview of metacharacters in different contexts:

### 1. **Shell Metacharacters (Bash, Unix/Linux)**
In shell environments, metacharacters are used to control how commands are interpreted. Here are some common ones:

- **`*`**: Matches any string of characters (including none). For example, `*.txt` matches all `.txt` files.
- **`?`**: Matches a single character. For example, `file?.txt` matches `file1.txt` and `fileA.txt`, but not `file10.txt`.
- **`[]`**: Matches any single character within the brackets. For example, `file[1-3].txt` matches `file1.txt`, `file2.txt`, and `file3.txt`.
- **`|`**: Used to pipe the output of one command into another. For example, `ls | grep 'txt'` lists files and then filters for those containing 'txt'.
- **`&`**: Runs a command in the background. For example, `sleep 10 &` will run the `sleep` command in the background.
- **`;`**: Separates commands, allowing you to run multiple commands in sequence. For example, `echo "Hello"; echo "World"` prints both strings.
- **`>` and `<`**: Redirect output to a file or input from a file, respectively. For example, `echo "Hello" > output.txt` writes "Hello" to `output.txt`.
- **`"` and `'`**: Used for quoting strings. Double quotes allow variable expansion (e.g., `$VAR`), while single quotes do not.

### 2. **Regular Expression Metacharacters**
In regular expressions, metacharacters have special meanings that allow for pattern matching in strings:

- **`.`**: Matches any single character (except newline).
- **`^`**: Matches the beginning of a line.
- **`$`**: Matches the end of a line.
- **`*`**: Matches zero or more occurrences of the preceding element.
- **`+`**: Matches one or more occurrences of the preceding element.
- **`?`**: Matches zero or one occurrence of the preceding element (makes it optional).
- **`{n}`**: Matches exactly `n` occurrences of the preceding element.
- **`{n,}`**: Matches `n` or more occurrences of the preceding element.
- **`{n,m}`**: Matches between `n` and `m` occurrences of the preceding element.
- **`|`**: Acts as a logical OR. For example, `cat|dog` matches either "cat" or "dog".
- **`()`**: Groups patterns together for applying quantifiers or capturing matches.
- **`[]`**: Denotes a character class. For example, `[abc]` matches either 'a', 'b', or 'c'.

### 3. **Programming Language Metacharacters**
In many programming languages, metacharacters are used in strings or for specific syntax rules. For example:

- **`\\`**: In many languages, this is used to escape special characters, such as quotes or newlines.
- **`\n`**: Represents a newline character.
- **`\t`**: Represents a tab character.

### Summary
Metacharacters are essential tools for manipulating strings, controlling command execution, and matching patterns. They vary in meaning depending on the context in which they are used, whether it's in shell commands, regular expressions, or programming languages. Understanding how to use metacharacters effectively can greatly enhance your ability to write scripts, analyze text, and manage data.

which command if there is an executable file 
it makes the use of the PATH variable to determine the location of the date. 


# 5.5 Command Types

internal commands are built in the shell 

external commands are binary executables stored in directories that are searched by the shell.
the -a option is for all 