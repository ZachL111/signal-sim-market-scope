# Field Notes

I would read this project from the data inward: cases first, implementation second.

The domain cases cover `input pressure`, `state drift`, `review cost`, and `decision risk`. They sit beside the smaller starter fixture so the project has both a compact scoring check and a domain-flavored review check.

`edge` is the strongest case at 244 on `review cost`. `baseline` is the cautious anchor at 91 on `input pressure`.

The extra check gives the repository a behavior path that can fail for a domain reason, not only a syntax reason.
