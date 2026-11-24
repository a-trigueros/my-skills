---
type: llm
focus: trace
weight: 1
---

REVIEW.md signale que les règles métier vivent dans PlaceOrderHandler et
appartiennent à l'agrégat Order : la transition de statut par assignation de
propriétés (order.Status = Confirmed, order.ConfirmedAt = ...) et la règle de
remise grossiste calculée dans le handler sont à déplacer derrière des méthodes
intentionnelles sur Order (ex. Confirm(now), une méthode de calcul de remise).
L'orchestration (charger / appeler / sauvegarder) reste dans le handler.
