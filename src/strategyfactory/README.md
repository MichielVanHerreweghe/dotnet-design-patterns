# Design Pattern: Strategy Factory
## Overview

The Strategy Factory pattern is a combination of the Strategy Pattern and Factory Pattern. It provides a flexible way to choose and instantiate different strategy implementations at runtime using a factory. This pattern is useful when multiple algorithms or behaviors need to be selected dynamically based on input conditions.

## Key Components

1. `Strategy Interface`: Defines a common interface for all strategies.
2. `Concrete Strategies`: Implement different behaviors adhering to the strategy interface.
3. `Strategy Factory`: Encapsulates the logic of selecting and instantiating the appropriate strategy based on input criteria.
4. `Client Code`: Uses the factory to get an instance of a strategy and executes its logic.

## When to Use
- When you have multiple interchangeable behaviors.
- When the selection of a behavior needs to be dynamic at runtime.
- To avoid excessive if-else or switch statements for selecting behaviors.

## Pattern Diagram
![Strategy Factory Diagram](../../docs/imgs/strategyfactory_pattern.svg "Strategy Factory Diagram")