# Exam Preparation 70-483 Programming in C#

## Tasks
You create 3 tasks `setupResource`, `useResource`  and `disposeResource` with `new Task()`. Each of them are long-running operation. You need to make sure, that they are executed sequentielly.

Which method of `Task` should you use?

## Asynchronous
```C#
static A B WriteMe(string path, string content) {
    var stream = new StreamWriter(path);
    C stream.D(content);
}
```

Select the correct replacement for `A`, `B`, `C`, `D` from the following list:
1. `Write()`
2. `WriteLine()`
3. `WriteLineAsync()`
6. `ReadAsync()`
4. `await`
5. `async`
7. `ToString()`
8. `Task`
9. `Task<bool>` 
10. `Task<StreamWriter>`
11. `StreamWriter`
12. `TaskResult`
