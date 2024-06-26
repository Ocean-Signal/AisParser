# AisParser

[![Build](https://github.com/yellowfeather/AisParser/actions/workflows/build.yml/badge.svg)](https://github.com/yellowfeather/AisParser/actions/workflows/build.yml)
[![CodeQL](https://github.com/yellowfeather/AisParser/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/yellowfeather/AisParser/actions/workflows/codeql-analysis.yml)
[![NuGet](http://img.shields.io/nuget/v/AisParser.svg)](https://www.nuget.org/packages/AisParser/)
[![MyGet](https://img.shields.io/myget/aisparser/v/aisparser)](https://www.myget.org/feed/Packages/aisparser)

C# decoder for Automatic Identification System (AIS) for tracking ships and decoding maritime information

Many thanks to [Eric S. Raymund](http://www.catb.org/~esr/) for [AIVDM/AIVDO protocol decoding](https://gpsd.gitlab.io/gpsd/AIVDM.html) and to the U.S. Department of Homeland Security for [Automatic Identification System Overview](https://navcen.uscg.gov/?pageName=AISmain)

Original project by Chris Richards (yellowfeather) and licensed under the MIT permissive license. Forked for use by Ocean Signal by Tim Long.

The Ocean Signal project has diverged from the original, here is a summary of the differences:

- Safety Related Broadcast (message 14) added and PR submitted back to the original project.
- "default" values return `null` in the original project; we return the actual value. For example, a heading value will be declared as `int` and contain 360 (an invalid bearing) to represent "no data" whereas the original package would have declared that as `int?` and returned `null`.
