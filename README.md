# my-skills

Skills personnels pour agents de codage IA.

## Skills

### [`my-craft/`](my-craft/) — règles de craftsmanship logiciel

S'applique à toute écriture, modification, correction, refactoring, revue ou
génération de code, dans tout langage. Encode :

- **L'échelle des garanties** : convention → assertion → test automatisé →
  analyseur statique → compilateur. Chaque règle est placée aussi haut que le
  langage le permet.
- **Les réflexes de conception** : états illégaux non représentables, modules
  profonds, pas d'abstraction hâtive (règle des trois), rien de spéculatif,
  erreurs qu'on est obligé de traiter (jamais de bool de succès), temps injecté comme I/O.
- **Les tests comme connaissance** : une classe `<Operation>Should` par
  opération, échecs en `Fail.When_<raison métier>`, un cycle
  rouge/vert/refactor à la fois — pas de code applicatif sans test rouge qui
  l'exige.
- **Une gate de paradigme** : profil OO fusion C# (encapsulation + style
  fonctionnel interne), profils Object Calisthenics par rôle de classe,
  idiomes propres pour les langages FP natifs.

Références : [`object-oriented.md`](my-craft/references/object-oriented.md)
(SOLID, calisthenics, renforcement du domaine),
[`validation-layers.md`](my-craft/references/validation-layers.md) (les quatre
couches de validation : frontend, exposition, domaine, système),
[`csharp.md`](my-craft/references/csharp.md),
[`testing.md`](my-craft/references/testing.md).

### [`my-rest/`](my-rest/) — contrats REST

Concevoir, construire, revoir et tester des API REST. Le code est régi par
`my-craft` ; ce skill régit le contrat HTTP lui-même :

- **Le contrat parle le domaine** : intentions métier sur du CRUD par défaut
  (`POST /orders/{id}/cancellations`), PATCH réservé au CRUD pur, méfiance
  envers le vocabulaire pseudo-fonctionnel.
- **La sémantique HTTP n'est pas négociable** : verbes, codes de statut,
  erreurs RFC 9457 Problem Details.
- **La représentation n'est pas le domaine** : DTO par opération, anti-couplage
  aux frontières, jamais de domaine sérialisé tel quel.
- **Niveau 2 Richardson pragmatique**, affordances quand le domaine porte un
  workflow explicite, OpenAPI comme substitut permanent à l'hypermedia.
- **Par défaut** : préfixe `/api`, versioning, pagination des collections,
  autorisation fermée par défaut, transformation d'erreurs centralisée.

Références : [`http-semantics.md`](my-rest/references/http-semantics.md)
(verbes, statuts, caching, versioning, erreurs),
[`dotnet.md`](my-rest/references/dotnet.md) (ASP.NET Core : Controllers /
Minimal API / FastEndpoints, validation, OpenAPI, tests d'intégration,
versioning, pagination Gridify).

## Installation

Installer les skills dans `~/.agents/skills` pour utilisation globale ou
, `.agents/skills` (projet) et les emplacements de compatibilité
`~/.claude/skills`, `~/.agents/skills`, `.claude/skills`, `.agents/skills`.

Un symlink suffit :

```sh
# global (tous les projets)
ln -s "$PWD/my-craft" ~/_.agents/skills/my-craft
ln -s "$PWD/my-rest"  ~/_.agents/skills/my-rest

# ou compatibilité Claude Code
ln -s "$PWD/my-craft" ~/.claude/skills/my-craft
ln -s "$PWD/my-rest"  ~/.claude/skills/my-rest

# ou limité à un projet
ln -s "$PWD/my-craft" <projet>/.agents/skills/my-craft
ln -s "$PWD/my-rest"  <projet>/.opencode/skills/my-rest

# ou limité à un projet Claude Code
ln -s "$PWD/my-craft" <projet>/.claude/skills/my-craft
ln -s "$PWD/my-rest"  <projet>/.claude/skills/my-rest

```

L'ID du skill vient du nom du dossier (`my-craft`, `my-rest`) ; la
`description` du frontmatter détermine quand l'agent se le voit proposer.

## Licence

[MIT](LICENSE) © 2026 Alexandre Trigueros
