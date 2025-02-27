#!/bin/zsh

# Directory to read (you can modify this to your desired folder)
directory="$1"

# Check if directory is provided as an argument
if [ -z "$directory" ]; then
    echo "Please provide a directory."
    exit 1
fi

# Check if the directory exists
if [ ! -d "$directory" ]; then
    echo "The directory does not exist."
    exit 1
fi

# Loop through all files in the directory and print their names
for file in "$directory"/*; do
    if [ -f "$file" ]; then
        echo "$(basename "$file")"  # Prints only the file name, not the full path
    fi
done
!#/bin/zsh 

# Directory to read (you can modify this to your desired folder
directory="$1"


# Check if directory is provided as an argument
if [ -z "$directory" ]; then 
  echo "Please provide a directory."
  exit 1
fi

