---
type: llm
focus: trace
weight: 1
---

La nouvelle lecture passe par un service de requêtes dédié qui projette
directement vers des DTO à partir de la source (ShipmentStore / ShipmentRow) :
AUCUN chargement d'agrégats via IShipmentRepository (pas d'appel à Find ou
ForCustomer suivi d'un mapping d'agrégat vers DTO) pour servir l'écran
« expéditions prêtes à partir ».
