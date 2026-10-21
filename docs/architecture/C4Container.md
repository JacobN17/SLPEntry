
# Architecture Overview

```mermaid
graph TD
    classDef person fill:#08427b,stroke:#052e56,color:#fff;
    classDef container fill:#1168bd,stroke:#0b4884,color:#fff;
    classDef db fill:#2b85c7,stroke:#1b5c8c,color:#fff;

    Clinician["Clinician (User)"]:::person

    sub:App["Clinical Rubric Desktop App (.NET / C#)
    - Presentation Layer (UI)
    - Application Services & Calculation Engine
    - Domain Core (Aggregates & Rules)
    - Infrastructure & EF Core"]:::container

    Database["Local SQLite Database
    (.db file on disk)"]:::db

    Clinician -->|Interacts with UI & Runs Evaluations| sub:App
    sub:App -->|Reads / Writes via EF Core| Database

    linkStyle 0,1 stroke:#444,stroke-width:2px;