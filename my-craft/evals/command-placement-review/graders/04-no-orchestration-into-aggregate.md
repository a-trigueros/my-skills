---
type: llm
focus: trace
weight: 1
---

REVIEW.md ne commet pas l'erreur inverse : AUCUNE demande de déplacer
l'orchestration dans l'agrégat — pas d'injection de IOrderRepository (ni d'autre
dépendance) dans Order, pas de chargement/sauvegarde confié à l'agrégat, pas de
suppression du handler au profit de l'agrégat.
