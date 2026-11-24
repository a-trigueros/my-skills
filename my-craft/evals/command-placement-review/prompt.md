---
tags: [skill-creator]
max_turns: 25
timeout_seconds: 900
allowed_tools: [Read, Glob, Grep, Skill, Write, Edit, Bash]
---

Review le code du dossier src avant merge : liste les problèmes de design par gravité décroissante dans REVIEW.md, à la racine du dossier.

Contexte : PlaceOrder est notre story CQRS — PlaceOrderHandler orchestre la création de commande ; Order est notre modèle du domaine ; IOrderRepository charge et sauvegarde les agrégats ; OrdersQueryHandler alimente l'écran de suivi des commandes ; OrderApiModel est le payload renvoyé au frontend.

Input files: src/Order.cs, src/PlaceOrderCommand.cs, src/PlaceOrderHandler.cs, src/IOrderRepository.cs, src/OrdersQueryHandler.cs, src/OrderApiModel.cs
