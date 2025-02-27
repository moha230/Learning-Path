# Linux Command-Line Utilities

## System Monitoring and Management
- **`top`**: Displays running processes and system resource usage in real-time.
- **`htop`**: Enhanced version of `top` with a more user-friendly interface for system monitoring.
- **`ps`**: Displays information about active processes.
- **`df`**: Shows disk space usage for file systems.
- **`du`**: Estimates and shows disk usage for files and directories.
- **`uptime`**: Tells how long the system has been running and load averages.
- **`free`**: Displays information about memory usage.
- **`kill`**: Sends signals to processes, often used to terminate processes by ID.
- **`uname`**: Shows system information such as kernel version and OS type.
- **`vmstat`**: Reports virtual memory statistics.

## File Management
- **`ls`**: Lists files and directories.
- **`cp`**: Copies files and directories.
- **`mv`**: Moves or renames files and directories.
- **`rm`**: Removes files or directories.
- **`touch`**: Creates an empty file or updates a file’s timestamp.
- **`mkdir`**: Creates new directories.
- **`rmdir`**: Removes empty directories.
- **`find`**: Searches for files and directories based on specified criteria.
- **`locate`**: Quickly finds files by name using a prebuilt database.
- **`ln`**: Creates links between files, often used for symbolic links.

## Text Processing
- **`cat`**: Concatenates and displays file contents.
- **`nl`**: Displays file content with line numbers.
- **`less`**: Opens files for reading with scrolling support.
- **`more`**: A simpler version of `less` for scrolling through files.
- **`head`**: Shows the beginning of a file.
- **`tail`**: Displays the end of a file, useful for real-time log monitoring.
- **`grep`**: Searches for patterns within files.
- **`sed`**: A stream editor for text replacement and manipulation.
- **`awk`**: A powerful text processing tool, useful for extracting and manipulating text in structured data.
- **`cut`**: Cuts out sections of each line in a file.
- **`tr`**: Translates or deletes characters in a file.
- **`wc`**: Counts words, lines, characters, and bytes in files.

## Archiving and Compression
- **`tar`**: Archives multiple files into one file, commonly used with compression.
- **`gzip` / `gunzip`**: Compresses and decompresses files using the gzip format.
- **`zip` / `unzip`**: Compresses and decompresses files in the zip format.
- **`bzip2` / `bunzip2`**: Compresses and decompresses files with bzip2 compression.
- **`xz`**: Compresses files using the xz format for higher compression rates.

## Networking
- **`ping`**: Checks connectivity to a host.
- **`curl`**: Transfers data from or to a server, supporting various protocols.
- **`wget`**: Downloads files from the internet.
- **`netstat`**: Displays network connections, routing tables, and interface statistics.
- **`ifconfig`**: Configures network interfaces (replaced by `ip` in many systems).
- **`ip`**: A powerful command for IP address configuration and network interface management.
- **`ss`**: Displays detailed network socket information.
- **`nmap`**: Network scanner to discover hosts and services on a network.
- **`ftp`**: File Transfer Protocol client for transferring files over the network.

## Package Management (varies by distribution)
- **`apt`**: Package manager for Debian-based distributions like Ubuntu.
- **`yum` / `dnf`**: Package managers for Red Hat-based distributions, like CentOS and Fedora.
- **`pacman`**: Package manager for Arch Linux.

## Disk and File System Management
- **`fdisk`**: A disk partitioning tool for managing disk partitions.
- **`mkfs`**: Creates a new file system on a disk partition.
- **`mount`**: Mounts file systems and storage devices.
- **`umount`**: Unmounts file systems and storage devices.
- **`fsck`**: Checks and repairs file systems.

## User and Group Management
- **`useradd` / `adduser`**: Creates new user accounts.
- **`usermod`**: Modifies user accounts.
- **`passwd`**: Sets or changes a user’s password.
- **`groupadd`**: Adds new groups to the system.
- **`id`**: Displays user and group information for the current or specified user.
- **`who`**: Shows who is logged into the system.
- **`last`**: Lists recent logins on the system.

## System Utilities
- **`date`**: Displays or sets the system date and time.
- **`cal`**: Displays a calendar.
- **`echo`**: Outputs text to the screen or another command.
- **`history`**: Shows the history of previously entered commands.
- **`alias`**: Creates shortcuts for commands.
- **`shutdown`**: Powers off or reboots the system.
- **`reboot`**: Restarts the system.
- **`clear`**: Clears the terminal screen.
