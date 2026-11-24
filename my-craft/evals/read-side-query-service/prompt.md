---
tags: [skill-creator]
max_turns: 30
timeout_seconds: 900
allowed_tools: [Read, Glob, Grep, Skill, Write, Edit, Bash]
---

Ajoute l'écran « expéditions prêtes à partir » dans la solution Shipments : pour préparer les tournées, la liste des expéditions en statut Ready avec id, client et date d'enregistrement. Le backend expose la lecture derrière une méthode appelable par l'écran.

Contexte : DispatchShipment est notre story d'écriture — DispatchShipmentHandler l'orchestre ; Shipment est notre modèle du domaine ; IShipmentRepository charge et sauvegarde les agrégats ; CustomerShipmentHistoryReader alimente déjà l'écran de suivi par client ; ShipmentApiModel est le payload renvoyé.

Input files: Shipments.slnx, Shipments/Shipments.csproj, Shipments/Shipment.cs, Shipments/IShipmentRepository.cs, Shipments/DispatchShipmentHandler.cs, Shipments/CustomerShipmentHistoryReader.cs, Shipments/ShipmentApiModel.cs, Shipments/ShipmentRow.cs, Shipments/ShipmentStore.cs, Shipments/InMemoryShipmentRepository.cs, Shipments.UnitTests/Shipments.UnitTests.csproj
