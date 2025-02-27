#include <pthread.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <fcntl.h>
#include <string.h>

// Function that each thread will execute to write to the file
void* write_to_file(void* arg) {
    int fd = *(int*)arg;
    const char* text = "Hello, POSIX World!\n";
    write(fd, text, strlen(text));  // Write text to the file
    printf("Thread wrote to file.\n");
    return NULL;
}

int main() {
    pthread_t thread;
    const char* filename = "posix_example.txt";
    int fd;

    // Open a file (create if it doesn't exist, truncate if it exists)
    fd = open(filename, O_CREAT | O_WRONLY | O_TRUNC, 0644);
    if (fd == -1) {
        perror("Failed to open file");
        exit(EXIT_FAILURE);
    }

    // Create a thread that will write to the file
    if (pthread_create(&thread, NULL, write_to_file, &fd) != 0) {
        perror("Failed to create thread");
        close(fd);
        exit(EXIT_FAILURE);
    }

    // Wait for the thread to complete
    pthread_join(thread, NULL);

    // Reopen the file descriptor before reading from the file
    fd = open(filename, O_RDONLY);  // Open in read-only mode
    if (fd == -1) {
        perror("Failed to reopen file for reading");
        exit(EXIT_FAILURE);
    }

    // Read the file content to verify the written data
    char buffer[1024];
    ssize_t bytes_read = read(fd, buffer, sizeof(buffer) - 1);
    if (bytes_read == -1) {
        perror("Failed to read file");
        close(fd);
        exit(EXIT_FAILURE);
    }

    buffer[bytes_read] = '\0';  // Null-terminate the buffer
    printf("File content: \n%s\n", buffer);

    // Close the file
    close(fd);
    return 0;
}

