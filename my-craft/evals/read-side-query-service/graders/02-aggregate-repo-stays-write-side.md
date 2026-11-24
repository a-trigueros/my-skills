---
type: llm
focus: trace
weight: 1
---

Le nouveau code n'ajoute aucune méthode de lecture écran à IShipmentRepository :
le contrat du repository reste dédié au chargement/sauvegarde d'agrégats pour
l'écriture, déclaré dans le domaine (namespace Shipments), implémentation dans
l'infrastructure. (Nommer le ForCustomer existant est bienvenu, le corriger n'est
pas exigé.)
