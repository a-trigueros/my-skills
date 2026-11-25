---
type: llm
focus: trace
weight: 1
---

REVIEW.md signale que les extensions de CommonHelpers vivent dans
Acme.Warehouse.Helpers au lieu du namespace des types étendus
(Acme.Warehouse.Domain) : la méthode d'extension se déclare dans le namespace
du type qu'elle étend, là où le consommateur la découvre.
