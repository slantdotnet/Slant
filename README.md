Slant projects
==============

[![Join the chat at https://gitter.im/slantdotnet/Slant](https://badges.gitter.im/slantdotnet/Slant.svg)](https://gitter.im/slantdotnet/Slant?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

## Overview

Slant is a several tools for ad-hoc and Agile application development with .NET. 

This is a meta-repository that contains links and common description of the Slant approach.

## Installation

We recommend to install every tool as a [the NuGet package](https://www.nuget.org/packages/Slant.Configuration). 

Install on the command line from your solution directory or use the Package Manager console in Visual Studio:

```powershell

PM> Install-Package Slant.{LibraryName}

```

where LibraryName is a appropriate Slant project name.

## Repositories

Available repos with released packages:

[Slant.Configuration](https://github.com/slantdotnet/Slant.Configuration)

[Slant.Linq](https://github.com/slantdotnet/Slant.Linq)

[Slant.Entity](https://github.com/slantdotnet/Slant.Entity)

Fork the project, make your changes, and then send a Pull Request.

## Contributing

Fork the projects, make your changes, and then send a Pull Request.

### Branch housekeeping

If you are a direct contributor to the project, please keep an eye on your past development or features branches and think about archiving them once they're no longer needed. 
No worries, their commits will still be available under named tags, it's just that they will not pollute the branch list.

If you're running on a Windows OS, there's a batch script available at `scripts\archive-branch.bat`. Otherwise, the command sequence to run in a *nix shell is the following:

```bash
# Get local branch from remote, if needed
git checkout <your-branch-name>

# Go back to master
git checkout master

# Create local tag
git tag archive/<your-branch-name> <your-branch-name>

# Create remote tag
git push origin archive/<your-branch-name>

# Delete local branch
git branch -d <your-branch-name>

# Delete remote branch
git push origin --delete <your-branch-name>
```

If you need to later retrieve an archived branch, just run the following commands:

```bash
# Checkout archive tag
git checkout archive/<your-branch-name>

# (Re)Create branch
git checkout -b <some-branch-name>
```

## Thanks to

Jetbrains Community Support for providing great tools for our team

[![Jetbrains Resharper](http://nspectator.org/assets/icon_ReSharper.png)](https://www.jetbrains.com/resharper/)



