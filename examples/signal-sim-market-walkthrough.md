# Signal Sim Market Scope Walkthrough

I use this file as a small checklist before changing the C# implementation.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 91 | hold |
| stress | state drift | 129 | watch |
| edge | review cost | 244 | ship |
| recovery | decision risk | 205 | ship |
| stale | input pressure | 244 | ship |

Start with `edge` and `baseline`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

The next useful expansion would be a malformed fixture around state drift and decision risk.
