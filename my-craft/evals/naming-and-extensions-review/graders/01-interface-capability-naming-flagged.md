---
type: llm
focus: trace
weight: 1
---

REVIEW.md signale que IInventoryChecker ne lit pas comme « I + ce que l'objet
fait » : la forme voulue pour l'interface est verbale (ICheckInventory ou
équivalent — ICheckStock...), l'implémentation prenant alors la forme nominale
(InventoryChecker).
