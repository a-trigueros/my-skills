---
tags: [skill-creator]
max_turns: 25
timeout_seconds: 900
allowed_tools: [Read, Glob, Grep, Skill, Write, Edit, Bash]
---

Review le code du dossier src avant merge : liste les problèmes de design par gravité décroissante dans REVIEW.md, à la racine du dossier.

Contexte : Warehouse prépare l'intake fournisseur — StockItem, Barcode et PurchaseOrder sont nos types du domaine ; IReserveStock, IInventoryChecker et IPriceOrders sont les capacités appelées par les écrans ; les classes d'extensions complètent les types sans les toucher.

Input files: src/Barcode.cs, src/StockItem.cs, src/PurchaseOrder.cs, src/StockReservation.cs, src/InventoryCheck.cs, src/Pricing.cs, src/CommonHelpers.cs, src/BarcodeExtensions.cs
