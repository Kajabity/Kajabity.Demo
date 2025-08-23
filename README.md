Kajabity.Demo
=============

![Kajabity.Demo logo](kajabity.demo.logo.png)

[![CI](https://github.com/kajabity/Kajabity.Demo/actions/workflows/ci.yml/badge.svg)](https://github.com/kajabity/Kajabity.Demo/actions/workflows/ci.yml)
[![CodeQL](https://github.com/kajabity/Kajabity.Demo/actions/workflows/codeql.yml/badge.svg)](https://github.com/kajabity/Kajabity.Demo/actions/workflows/codeql.yml)
[![NuGet](https://img.shields.io/nuget/v/Kajabity.Demo.svg)](https://www.nuget.org/packages/Kajabity.Demo/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Kajabity.Demo.svg)](https://www.nuget.org/packages/Kajabity.Demo/)
[![GitHub Release](https://img.shields.io/github/v/release/kajabity/Kajabity.Demo.svg)](https://github.com/kajabity/Kajabity.Demo/releases)
[![License](https://img.shields.io/github/license/kajabity/Kajabity.Demo.svg)](https://github.com/kajabity/Kajabity.Demo/blob/main/LICENSE)

Overview
--------

Kajabity.Demo is a simple example NuGet package produced for an article on how to create and
publish a NuGet package. It demonstrates a minimal library and test setup, suitable as a starting
point or template.

Features
--------

- Simple demo class with a method to double an integer.
- Multi-targeted builds for modern .NET and .NET Standard.
- Provides a template for build, test, package and key maintenance actions in GitHub.

Installation
------------

Install the package from NuGet with:

```shell
dotnet add package Kajabity.Demo
```

Usage
-----

Here is a basic example of how to use the library once included in a project:

```csharp
using Kajabity.Demo;

ComplexCalculation cc = new ComplexCalculation();
int value = cc.TimesTwo(9);
```

Releases
--------

- **Latest GitHub Release:** [View on GitHub](https://github.com/kajabity/Kajabity.Demo/releases/latest)
- **Latest NuGet Package:** [View on NuGet.org](https://www.nuget.org/packages/Kajabity.Demo/)

Feedback & Contributions
-------------------------

To offer feedback or ask questions, either comment on the associated article
at [kajabity.com](https://www.kajabity.com/) or raise an issue on GitHub.

Contributions are welcome if you notice anything that could be improved.

Development Notes
-----------------

### Pre-commit and Security Tools

Run gitleaks using Docker:

```shell
docker run -v ${pwd}:/path ghcr.io/gitleaks/gitleaks:latest detect --source /path -v
```

Run all the pre-commit hooks:

```shell
pre-commit run --all-files
```
