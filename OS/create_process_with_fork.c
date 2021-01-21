#include <sys/types.h>
#include <sched.h>
#include <stdlib.h>
#include <stdio.h>
#include <malloc.h>

#define STACK_SIZE 1024

int with_fork()
{
    pid_t pid;
    pid = fork();

    if (pid == 0)
        printf("It's a child process");
    else
        printf("It's a parent process");

    return 0;
}

int new_process()
{
    printf("It's a new process!");
    return 1;
}

void with_clone()
{
    int pid;
    void* stack;

    stack = malloc(STACK_SIZE);
    if(stack == 0)
    {
        printf("Memory Allocate Error!");
        exit(1);
    }

    pid = clone(&new_process, (char*) stack + STACK_SIZE, 0, 0);

    pid = waitpid(pid, NULL, 0);
    printf("Child process terminated");
    free(stack);
}

int main(int argc, char *argv[])
{
    with_clone();
    return 0;
}