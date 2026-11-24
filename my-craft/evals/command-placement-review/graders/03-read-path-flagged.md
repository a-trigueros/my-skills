---
type: llm
focus: trace
weight: 1
---

REVIEW.md signale le chemin de lecture d'OrdersQueryHandler : charger des
agrégats via IOrderRepository (All()) pour fabriquer des DTO est un détour par
le modèle d'écriture — une lecture passe par un service de requêtes qui projette
directement vers les DTO à afficher, sans charger d'agrégats.
