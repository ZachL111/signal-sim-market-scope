# Review Journal

The cases below are the review handles I would use before changing the implementation.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 91, lane `hold`
- `stress`: `state drift`, score 129, lane `watch`
- `edge`: `review cost`, score 244, lane `ship`
- `recovery`: `decision risk`, score 205, lane `ship`
- `stale`: `input pressure`, score 244, lane `ship`

## Note

The useful failure mode here is a wrong decision on a named case, not a vague style disagreement.
