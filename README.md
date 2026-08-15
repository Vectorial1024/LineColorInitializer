# Line Color Initializer
A Cities Skylines mod to initialize public transport lines with a random color. A zero-config solution to color choice paralysis.

This is to provide a simple modern remake/reimagination of the following first-generation mods:

- TransportLineColorMod (2015) by tuopppi
- Auto Line Color (2015) by enkafan and FrF
- AutoLineColor Redux (2018) by TaradinoC

Salute to the departed forebears, as we venture into the future.

## Mod Status

- Requires Harmony
- Compatible with:
  - Improved Public Transport Essentials ("IPTE")
- Incompatible with:
  - Transport Lines Manager ("TLM")
    - TLM has custom built-in line color initialization; you should use that

## Mod Effects

This mod is very simple:

When you use the PT line tool to create a new PT line (`TransportManager.CreateLine`), this mod immediately assigns a random color to this new line using a Harmony patch.

This random color is picked from the web industry-standard [CSS "named colors" list](https://developer.mozilla.org/en-US/docs/Web/CSS/Reference/Values/named-color), containing colors that have credible history (and therefore sensible artistic appeal).

Cities Skylines has a hard cap of 256 public transport lines per city, and this mod has only around 150 colors.
The Birthday Paradox suggests likely color collision, but in practice this is not gonna happen that easily, and color collisions are easily manageable by the player.

## Differences from Legacy Mods

This mod fires only once during public transport line creation, which is a game-internal technical step without equivalent GUI feedback.

This means this mod does not cause continuous lag on your cities, unlike the legacy mods (which hooks onto the simulation step to regularly loop over your public transport lines).

This also means this mod (at least at this stage) will never handle district-level color/name standardization, because that requires information not available during initialization.
