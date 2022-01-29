# Dial-ality
Game Jam 2022

## Resources

- [Puzzle Mechanics Google Doc](https://docs.google.com/document/d/1JnRRYaNw4ot0yHyakc_7VcqkEgC7JCkjlv_9l6RiQNM/edit?usp=sharing)

- Unity Version: 2021.1.24

## Puzzle Mechanics

We've identified these main game objects that will exist on the planet: `mountains`, `lake`, `farm` and `cloud`.

`mountains`, `lake`, and `farm` are regions on the planet. Their `sun_level` changes with their relative position to the sun. As the `sun_level` changes, their visual state changes. 

The will be a `cloud` object that is created by holding the `lake` region under the sun. The `cloud` object will _not_ rotate with the planet, but stay in the sky under the sun while regions are moved below it. 

The goal is for the user to complete this sequence:

- hold `lake` under sun until cloud appears
- rotate `mountains` under cloud, which will make the cloud rain. It will alse change the `mountain.watered?` variable to true, and snow will appear.
- rotate the `farm` under the raining cloud. This will change the `farm.watered` state to `true`. Thi will dissapate the cloud, which will dissappear. Then the `farm` will be under the sun, and plants will grow.

- mountains
  - state variables
    - watered?: bool
    - sun_level: int: 0 - 4
- lake
  - state variables
    - sun_level: int: 0 - 4
- cloud
  - state variables
    - raining?: bool
- farm
  - state variables
    - watered?: bool
    - sun_level: 0 - 4

## Asset List

- mountain
  - no snow
  - no snow + heat lines
  - on fire
  - snow
  - snow + heat lines
- lake
  - frozen 
  - frozen + heat lines
  - unfrozen water
  - unfrozen water + heat lines
- cloud
  - not raining
  - raining
- farm
  - default (green field?)
  - default + heat lines
  - sunburnt
  - growing crops
