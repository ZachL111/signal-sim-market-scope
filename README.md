# signal-sim-market-scope

`signal-sim-market-scope` explores simulations with a small C# codebase and local fixtures. The technical goal is to create a C# reference implementation for market workflows, centered on storage recovery, log and snapshot fixtures, and replay consistency checks.

## Why I Keep It Small

The project exists to keep a narrow engineering decision visible and testable. For this repo, that decision is how input pressure and review cost should influence a review result.

## Signal Sim Market Scope Review Notes

Start with `review cost` and `input pressure`. Those cases create the widest score spread in this repo, so they are the best quick check when the model changes.

## Included Behavior

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/signal-sim-market-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `review cost` and `input pressure`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Internal Model

The fixture data drives the tests. The code stays thin, while `metadata/domain-review.json` and `config/review-profile.json` explain what each case is meant to protect.

The C# addition stays small enough to inspect in one sitting.

## Try It Locally

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Validation

The same command runs the local verification path. The highest-scoring domain case is `edge` at 244, which lands in `ship`. The most cautious case is `baseline` at 91, which lands in `hold`.

## Scope

The fixture set is small enough to audit by hand. The next useful expansion is malformed input coverage, not extra surface area.
