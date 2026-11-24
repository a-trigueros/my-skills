# DDD layering — who does what

Reference for codebases organized in DDD layers. Each building block holds
exactly one role, and a change lands in the block whose role it serves.
Writes (commands) and reads (queries) are two separate paths through the
application layer:

```
┌────────────────── Application layer ──────────────┐
Controller ──command──▶ Application Service (command handler)
│ │ loads/saves │ provides
│ ▼ ▼
│ Repository ──▶ Entity/Aggregate ◀── Domain Service │ ← Domain
│ │
Controller ──query────▶ Application Service (query handler)
│ │
│ ▼
│ Query Service ──▶ DTO │
└────────────────────────────────────────────────────┘
```

| Component | Layer | Role | It knows… |
| --- | --- | --- | --- |
| Application Service | Application | Orchestrate a use case | The order in which things happen |
| Aggregate | Domain | Protect its invariants | What is allowed on itself |
| Domain Service | Domain | Apply a rule that exceeds one aggregate | What is allowed beyond an aggregate |
| Repository | Domain (contract) / Infra (impl.) | Load and save an aggregate | How to find it |
| Query Service | Application (contract) / Infra (impl.) | Serve data to display | What to show |

The table settles placement: orchestration stays out of the aggregate — a
command handler loads, calls one intention-revealing method, saves. A rule
beyond one aggregate is a domain service handed to the aggregate as a
parameter (double dispatch — see `references/object-oriented.md`), never a
step the handler performs itself. Reads bypass aggregates: a query handler
goes through the query service straight to DTOs, never through a repository
and an aggregate. A repository contract lives in the domain, its
implementation in infrastructure.
