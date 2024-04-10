# Core concepts of C#
![image](https://github.com/v-dav/C-sharp-.NET/assets/115344057/d3f666bd-7dd4-416d-84fa-3205c501d956)


## .NET
- .NET is a framework for building applicaitons on Windows
- .NET has 2 components:
	- CLR: Commun Language Runtime
	- Class Library for building applications

## Commun Language Runtime

When we compile the C# code, the result is what we call IL or Intermediate Language code which is independent of the computer running. CLR is an application to translate IL code into the machine code, and this process is calles, Just in time Compilation (JIT). As long as the machine has a CLR it can run the C# application, like with Java and JVM.

## Architecture of .NET applications

### Classes
The .NET application consists of building blocks called classes. As our application grows the nubmer of classes also grows, so we need a way to organize these classes. Thats where we use namespaces.

### Namespaces
A namespace is a container for related classes.

### Assembly (DLL or EXE)
As our application grows we need a  way to partition it, so thats where we use assembly, which is a container for related namespaces.
It's a file on a dis which can be an executable or DLL which stands for Dynamically Linked Library.

## Primitive Types
![Skärmavbild 2024-04-10 kl  10 29 31](https://github.com/v-dav/C-sharp-.NET/assets/115344057/c1ed1955-8f35-4cc7-8679-77251998f82d)

