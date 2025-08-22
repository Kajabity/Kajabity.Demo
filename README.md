Kajabity.Demo
=============

[![CI](https://github.com/kajabity/Kajabity.Demo/actions/workflows/ci.yml/badge.svg)](https://github.com/kajabity/Kajabity.Demo/actions/workflows/ci.yml)
[![CodeQL](https://github.com/kajabity/Kajabity.Demo/actions/workflows/codeql.yml/badge.svg)](https://github.com/kajabity/Kajabity.Demo/actions/workflows/codeql.yml)
[![NuGet](https://img.shields.io/nuget/v/Kajabity.Demo.svg)](https://www.nuget.org/packages/Kajabity.Demo/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Kajabity.Demo.svg)](https://www.nuget.org/packages/Kajabity.Demo/)
[![GitHub Release](https://img.shields.io/github/v/release/kajabity/Kajabity.Demo.svg)](https://github.com/kajabity/Kajabity.Demo/releases)
[![License](https://img.shields.io/github/license/kajabity/Kajabity.Demo.svg)](https://github.com/kajabity/Kajabity.Demo/blob/main/LICENSE)

About
-----

Kajabity.Demo NuGet as an example produced for an article on how to create and
publish a NuGet package.

There are full details in the associated article at [kajabity.com](https://www.kajabity.com/).

This is a basic package and has no special requirements to use it.

The package provides a single class with one method that doubles any integer
passed into it.

How To Use
----------

Here is an example of how to use it, once the package has been included in a
project:

```cs
ComplexCalculation cc = new ComplexCalculation();
int value = cc.TimesTwo(9));
```

To offer feedback or ask questions either comment on the article or raise an
issue on GitHub.

I also welcome contributions if you notice anything that could be improved.

Releases
--------

- **Latest GitHub Release:** [View on GitHub](https://github.com/kajabity/Kajabity.Demo/releases/latest)
- **Latest NuGet Package:** [View on NuGet.org](https://www.nuget.org/packages/Kajabity.Demo/)

Development
-----------

Run gitleaks using Docker:

```shell
docker run -v ${pwd}:/path ghcr.io/gitleaks/gitleaks:latest detect --source /path -v
```

Run all the pre-commit hooks:

```shell
pre-commit run --all-files
```
