<!-- readme.md v1.6.9.2
On Demand Fuel Cells (ODFC)
created: 17 Jul 2017
updated: 05 Jul 2022 -->

<!--this file: CC BY-ND 4.0 by zer0Kerbal-->

[![On Demand Fuel Cells (ODFC)][MOD:shd:latest]][MOD:forum] [![KSP version][KSP:shd]][KSP:url]  [![License][LIC:shd]][LIC:url]  
[![Curseforge][CURSFG:shd]][CURSFG:url] [![GitHub][GITHUB:shd]][GITHUB:url] [![SpaceDock][SPCDCK:shd]][SPCDCK:url] [![CKAN][CKAN:shd]][CKAN:url]   
[![Pages][MOD:pages:shd]][MOD:pages]



# On Demand Fuel Cells (ODFC)

## By [`zer0Kerbal`][zer0Kerbal], originally by [`Orum`][orum]

adopted with *express* permission and brought to you by *KerbSimpleCo*

<img src="https://raw.githubusercontent.com/zer0Kerbal/OnDemandFuelCells/master/img/HeroLogo_1920x1920.png" alt="OnDemandFuelCells Hero" width="72%" height="72%">


### Preamble by [`Orum`][orum]
>
>On Demand Fuel Cells (ODFC) is a plugin to simulate fuel cells in Kerbal Space Program (KSP), and do a better job of it than stock's use of a resource converter.  The main difference is it only generates electricity when it's really needed (batteries almost empty), and otherwise lets electricity of a craft float up and down, as it might in a solar powered vehicle when the sun is eclipsed by another celestial body.  It also allows fuel cells to generate byproducts, aimed at supporting life support mods like TACLS.

The plugin requires a set of Module Manager patches to function, as it does not do anything unless integrated into a part. There are two different sets of patches available on CKAN or SpaceDock.
One set that copies the fuel cells from Stock, Universal Storage 2, Jatwaa Demolitions Co, and Solid Fuel Cells (soon more) and replaces the stock modules with ODFC with three modes (four if Community Resource Pack is installed correctly) of operation. Also adds a 0.5 EC/s multimode fuel cell to all stock command pods (easily disabled since in separate patch)
Another set that modifies the same set of parts instead of copying them.

### Features

* adjustable fuel cell use - much more than just On/Off operation
* multiple fuel modes (serial usage - one mode at a time)
* variable activation threshold
* configurable to produce byproducts (so O+H2 = EC + H2O)
* very small memory footprint
* Brown and Black out protection assistance
* PAW (Part Action Window / Right Click Menu) grouping with auto collapse, *click the down arrow to drop the ODFC control panel down (KSP 1.7.1).*
* Two new features from the game settings:
  * Stall: fuel cell stops working if vessel total electric charge falls to close to zero (0f) and will not start until there is more electric charge. Fuel cells require EC to work.
  * autoSwitch: automatically switched fuel mode looking for fuel if the current mode becomes fuel deprived.
* more features coming soon

### See More

* See our [Parts Catalog][MOD:parts] for part pictures
* For more images, see our [Marketing Slicks][MOD:markt]
* Discussions and news on this mod: See [Discussions][MOD:discu] or [KSP Forums][MOD:forum]
* Changelog Summary for more details of changes: See [ChangeLog][MOD:chlog]
* Known Issues for more details of feature requests and known issues : See [Known Issues][MOD:issue]
* GitHub Pages : See [Pages][MOD:pages]

---

![Hero Image][IMG:hero:0]

### Help Wanted

> * Compatibility patches
> * Contracts for these glorious parts
> * Marketing Images and Videos such as hero shots, animated gifs, short highlight
> * Have a request? Glad to have them, kindly submit through [GitHub][MOD:issue].

---

### Localization

>* ![English][EN] English
>* ***your translation here***
>
> HELP WANTED - See the [README in the Localization folder][lreadme] or the [Quickstart Guide][qstart] for instructions for adding or improving translations. [GitHub][GitHub:url] push is the best way to contribute. *Additions and corrections welcome!*

---

### Installation Directions [^1]

***Use***
  CurseForge/OverWolf App (currently does not install dependencies)  

  <a href="https://download.curseforge.com/">
    <img src="https://www.overwolf.com/brand-guidelines/img/logo2.svg" alt="CurseForge/OverWolf App" width="15%" height="15%">
</a>

Whilst I agree CKAN is a great mod for those that can't use zip tools. I take no part, nor am I interested in maintaining the CKAN mod metadata for my mods.
Please don't ask me about it but refer to the CKAN mod thread if you are having issues with CKAN or the metadata it maintains. Beware, CKAN *can* really mess up though it tries very, very, very hard not to.

or [![CKAN][CKAN:img]][CKAN:url]

### Dependencies

* [Kerbal Space Program][KSP:url] [![Kerbal Space Program][KSP:shd]][KSP:url] [^2]
* Either [^3]
  * [Module Manager][mm]
  * [Module Manager /L][mml]

* ***Parts designed to use, or patches to modify existing parts*** *This addon does nothing by itself.*

### Supports

* [GPO (Goo Pumps & Oils') Speed Pump (GPO)][GPO]
* [AllYAll][all] - supports by removing
* Either
  * [BackgroundProcessing][bgp] *(exclusive to BackgroundResources) (see known issues list)*
  * [Background Resources][bgr] *(exclusive to BackgroundProcessing) (see known issues list)*
* [Community Resource Pack][crp]

### Suggests (These mods have Fuel Cells)

* [Hot Beverages Irradiated - Fuel Cells (HBI/FC)][HBIFC]
* [Bluedog Design Bureau][bdb]
* [Stockalike Mining Extension (SMX)][smx]
* [Univeral Storage II][us2]
* [Universl Storage][us1]
* [RLA Reborn][rla]
* [Solid Fuel Cells][sfc]
* [Jatwaa Demolitions Co][jdf]

### Does not work with parts from (because they use own generation MODULES)

* Kethane
* USI
* @Angel-125's mods (Buffalo, Pathfinder, et al)

### CONFLICTS

* [ODFC-Refueled-CopyPatches][ODFC-C]
* [ODFC-Refueled-ModifyPatches][ODFC-M]

### REPLACES

* [ODFC][]
* [ODFC - On Demand Fuel Cells by Orum](http://forum.kerbalspaceprogram.com/index.php?/topic/138431-111-*) >-- ORIGINAL (outdated)--<
* [ODFC-Refueled][ODFC-R]

### Tags

plugin, config, flags, agency, control, convenience, sound, resources

<div style="border:0.5px solid Tomato; background-color: #BADA55; color: #FF0000; text-align:center">
  <p><b>red box below is a link to forum post on how to get support</b></p>
  <a href="https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*">
    <p><img src="https://i.postimg.cc/vHP6zmrw/image.png" alt="How to get support"></p></a>
  <p style="color: #000000;">Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date</p>
</div>

### Credits and Special Thanks

* [Orum][orum] for creating this glorious addon!
* [`4x4cheesecake`][4x4cheesecake] for helping with the initial adoption
* see [Attribution.md][MOD:attr] for more comprehensive list

### Known Issue Tracker

* [NEW][BUG 1.1.2.1a] AmpYear doesn't seem to recognize ODFC
* [BUG 1.1.2.0a] TweakScale will not scale module ODFC
* [BUG 1.1.2.0b] Kerbalism doesn't recognize ODFC, ODFC still functions correctly
* [BUG 0.0.1.9a] B9 doesn't work on ODFC enabled parts
* [BUG 0.0.1.9b] next fuel mode should not be visible when only one mode
* [BUG 0.0.1.6a] BackgroundProcessing or Background Resources mods don't see ODFC, so ODFC doesn't work when doesn't have focus. Should not have both BackgroundProcessing and BackgroundResources installed.
* *any mod that requires to use onLoad() instead of onStart() to update a part*

---

### Legal Mumbo Jumbo (License *provenance*)

#### Current (4) - [`zer0Kerbal`][zer0Kerbal]

> Forum: [Thread][MOD:forum] - Source: [GitHub][GITHUB:url]  
> License: [![License][LIC:shd]][LIC:url] ![License][LIC:log]
>
> ##### Disclaimer(s)
>
> ***All bundled mods are distributed under their own licenses***  
> ***All art assets (textures, models, animations, sounds) are distributed under their own licenses***

##### see [Notices.md][MOD:notic] for more *legal mumbo jumbo*

#### Original (3) - [`zer0Kerbal`][zer0Kerbal]

> Forum: [Thread][MOD:2:thread] - Download: [CurseForge][MOD:2:dnload] - Source: [GitHub][MOD:2:source]  
> License: [![License][LIC:2:shd]][LIC:2:url] ![License][LIC:2:log]

#### Original (1) - Author: [`'Orum`][orum1]

> Forum: [Thread][MOD:1:thread] - Download: [SpaceDock][MOD:1:dnload] - Source: [Dropbox][MOD:1:source]  
> License: [![License][LIC:1:shd]][LIC:1:url] ![License][LIC:1:log]

#### Original (0) - Author: [`Orum`][orum]

> Forum: [Thread][MOD:0:thread] - Download: [Dropbox][MOD:0:dnload] - Source: [Dropbox][MOD:0:source]  
> License: [![License][LIC:0:shd]][LIC:0:url] ![License][LIC:0:log]

---

### How to support this and other great mods by [`zer0Kerbal`][zer0Kerbal]  

[![Support][PAYPAL:img]][PAYPAL:url] [![Github Sponsor][GSPONS:img]][GSPONS:url] [![Patreon][PATREON:img]][PATREON:url] [![Buy zer0Kerbal a snack][BMCC:img]][BMCC:url]

<!-- mod links -->
[MOD:attr]: https://zer0kerbal.github.io/OnDemandFuelCells/Attributions "Attribution"
[MOD:chlog]: https://raw.githubusercontent.com/zer0Kerbal/OnDemandFuelCells/master/changelog.md  "Changelog"
[MOD:contr]: https://github.com/zer0Kerbal/.github/blob/master/.github/CONTRIBUTING.md "Contributing"
[MOD:discu]: https://github.com/zer0Kerbal/OnDemandFuelCells/discussions "Discussions"
[MOD:forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-*/ "OnDemandFuelCells Forum Thread"
[MOD:issue]: https://github.com/zer0Kerbal/OnDemandFuelCells/issues "Issues"
[MOD:licns]: https://github.com/zer0Kerbal/OnDemandFuelCells/blob/master/LICENSE "Github License"
[MOD:markt]: https://zer0kerbal.github.io/OnDemandFuelCells/Marketing "Marketing Slicks"
[MOD:notic]: https://zer0kerbal.github.io/OnDemandFuelCells/Notices "Notices"
[MOD:parts]: https://zer0kerbal.github.io/OnDemandFuelCells/PartsCatalog "Parts Catalog"
[MOD:pages]: https://zer0kerbal.github.io/OnDemandFuelCells "GitHub Pages"

<!--- mod -->
[MOD:shd:latest]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OnDemandFuelCells/master/json/mod.json

[CODE:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OnDemandFuelCells/master/json/code.json

[MOD:pages:shd]: https://img.shields.io/badge/GitHub-Pages-white?style=plastic&labelColor=9cf&logoColor=181717&logo=github "GitHub IO"

<!--- mod provenance -->
[MOD:2:dnload]: https://www.curseforge.com/kerbal/ksp-mods/OnDemandFuelCells "CurseForge"
[MOD:2:source]: https://github.com/zer0Kerbal/OnDemandFuelCells "GitHub"
[MOD:2:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-*/ "KSP Forum"

[MOD:1:dnload]: https://spacedock.info/mod/618 "SpaceDock"
[MOD:1:source]: https://www.dropbox.com/s/0rpp4138jumvaxq/ODFC_v1.1.zip "Dropbox"
[MOD:1:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/138431-*/ "KSP Forum"

[MOD:0:dnload]: https://www.dropbox.com/s/k1120x68899vcr1/ODFC_1.0.zip "Dropbox"
[MOD:0:source]: https://www.dropbox.com/s/k1120x68899vcr1/ODFC_1.0.zip "Dropbox"
[MOD:0:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/99761-*/ "KSP Forum"

<!--- license provenance -->
[LIC:2:url]: https://creativecommons.org/licenses/by-nc-sa/4.0/ "CC BY-NC-SA 4.0"
[LIC:2:log]: https://licensebuttons.net/i/l/by-nc-sa/transparent/33/66/99/76x22.png "CC BY-NC-SA 4.0"
[LIC:2:shd]: https://img.shields.io/badge/License-CC%20BY--NC--SA%204.0-ef9421?labelColor=black&style=plastic&logoColor=ef9421&logo=creativecommons "CC BY-NC-SA 4.0"

[LIC:1:url]: https://creativecommons.org/licenses/by-nc-sa/4.0/ "CC BY-NC-SA 4.0"
[LIC:1:log]: https://licensebuttons.net/i/l/by-nc-sa/transparent/33/66/99/76x22.png "CC BY-NC-SA 4.0"
[LIC:1:shd]: https://img.shields.io/badge/License-CC%20BY--NC--SA%204.0-ef9421?labelColor=black&style=plastic&logoColor=ef9421&logo=creativecommons "CC BY-NC-SA 4.0"

[LIC:0:url]: https://creativecommons.org/licenses/by-nc-sa/4.0/ "CC BY-NC-SA 4.0"
[LIC:0:log]: https://licensebuttons.net/i/l/by-nc-sa/transparent/33/66/99/76x22.png "CC BY-NC-SA 4.0"
[LIC:0:shd]: https://img.shields.io/badge/License-CC%20BY--NC--SA%204.0-ef9421?labelColor=black&style=plastic&logoColor=ef9421&logo=creativecommons "CC BY-NC-SA 4.0"

[LIC:url]: https://www.gnu.org/licenses/gpl-2.0-standalone.html "GPL-2.0"
[LIC:log]: https://i.postimg.cc/9FrwMgK6/GPL-17x17.png "GPL-2.0"
[LIC:shd]:  https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OnDemandFuelCells/master/json/license.json "GPL-2.0"

<!--- AVC -->
[AVC:shd]: https://img.shields.io/badge/KSP-AVC--supported-00C961.svg?labelColor=black&style=plastic
[AVCVLD:shd]: https://github.com/zer0Kerbal/OnDemandFuelCells/workflows/Validate%20AVC%20.version%20files/badge.svg?labelColor=black&style=plastic "AVC-Valid - thank you to DasSkelett"

<!--- CKAN -->
[CKAN:img]: https://i.postimg.cc/x8XSVg4R/sj507JC.png "CKAN"
[CKAN:url]: http://forum.kerbalspaceprogram.com/index.php?/topic/197082-*/ "CKAN"
[CKAN:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OnDemandFuelCells/master/json/ckan.json "CKAN"

<!--- release links -->
[CURSFG:url]: https://www.curseforge.com/kerbal/ksp-mods/OnDemandFuelCells "Curseforge"
[CURSFG:shd]: https://img.shields.io/badge/CurseForge-Link-CCFF00.svg?labelColor=6441A4&style=plastic&logo=curseforge "Curseforge"

[GITHUB:url]: https://github.com/zer0Kerbal/OnDemandFuelCells/ "GitHub"
[GITHUB:shd]: https://img.shields.io/badge/Github-Link-CCFF00.svg?labelColor=181717&style=plastic&logo=github "GitHub"

[SPCDCK:url]: http://spacedock.info/mod/2223 "SpaceDock"
[SPCDCK:shd]:  https://img.shields.io/badge/SpaceDock-Link-CCFF00.svg?labelColor=181717&style=plastic&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPgo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkxheWVyXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IgoJIHZpZXdCb3g9IjAgMCA1MDAgNTAwIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MDAgNTAwOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6IzFBMUExQTt9Cgkuc3Qxe2ZpbGw6IzA1Nzg5Mzt9Cgkuc3Qye2ZpbGw6IzA3QUNEMjt9Cjwvc3R5bGU+CjxwYXRoIGlkPSJYTUxJRF8xXyIgY2xhc3M9InN0MCIgZD0iTTQwMCwwLjZIMTAwYy01NSwwLTEwMCw0NS0xMDAsMTAwVjQwMGMwLDU1LDQ1LDEwMCwxMDAsMTAwaDMwMGM1NSwwLDEwMC00NSwxMDAtMTAwVjEwMC42CglDNTAwLDQ1LjYsNDU1LDAuNiw0MDAsMC42eiIvPgo8ZyBpZD0iWE1MSURfNl8iPgoJPGcgaWQ9IlhNTElEXzlfIj4KCQk8cGF0aCBpZD0iWE1MSURfMTdfIiBjbGFzcz0ic3QxIiBkPSJNMTgzLjMsMTY1LjljNi40LTMuNiwxNi45LTMuNiwyMy4zLDBMNDY3LjQsMzE0YzYuNCwzLjYsNi40LDkuNiwwLDEzLjJMMjA2LjYsNDc0LjQKCQkJYy02LjQsMy42LTE3LjcsNi42LTI1LDYuNmgtNDQuOGMtNy40LDAtOC4xLTMtMS43LTYuNmwyNjEtMTQ3LjJjNi40LTMuNiw2LjQtOS42LDAtMTMuMkwxNzEsMTg2Yy02LjQtMy42LTYuNC05LjYsMC0xMy4yCgkJCUwxODMuMywxNjUuOXoiLz4KCTwvZz4KCTxnIGlkPSJYTUxJRF84XyI+CgkJPHBhdGggaWQ9IlhNTElEXzE2XyIgY2xhc3M9InN0MiIgZD0iTTMxOC44LDE5Yy03LjQsMC0xOC42LDIuOC0yNSw2LjRMMzMsMTczLjRjLTYuNCwzLjYtNi40LDkuNSwwLDEzLjFsMjYwLjcsMTQ3LjEKCQkJYzYuNCwzLjYsMTYuOSwzLjYsMjMuMywwbDEyLjMtN2M2LjQtMy42LDYuNC05LjUsMC0xMy4ybC0yMjUuMS0xMjdjLTYuNC0zLjYtNi40LTkuNSwwLTEzLjJMMzY1LjYsMjUuNGM2LjQtMy42LDUuNi02LjQtMS43LTYuNAoJCQlIMzE4Ljh6Ii8+Cgk8L2c+CjwvZz4KPC9zdmc+Cg==  "SpaceDock"

<!-- Kerbal Space Program -->
[KSP:url]: https://kerbalspaceprogram.com/ "Kerbal Space Program"
[KSP:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/OnDemandFuelCells/master/json/ksp.json&logo=data:image/webp;base64,UklGRpAGAABXRUJQVlA4TIQGAAAvH8AHEE0obNsGDakwXkT/Q4chj76jn1yYjSRjH6H+6xQqRUkkSc5ckHD+NUUVhx4+RNu2bTTl/3OTVhD6H8u6fF8dDYm40CK7N0CjAxK52rYtjfQRAvGNjbu7V+vuLp2fwhzA6gG4li6de+nuO+4uJBlkwoTA//90kENgtZZs27ZpO2Oufa5vbNsq2Sw6qaa9r3n/kZJTex/wSrFt27o62kuSJNuqrdTa1+/7uLu7uzQZAk0mRN/mAz2CAbi723vvy5WztxxIAAiw+dh2bdvWZJuT12y1bdu2bdu2bbs3AQABlsED+y50lDqLE4pf/Uxe8KO77HFes9hvxu1p3O2Q09LVg0NVjo7Z5U6AvwBSOfivKdQTujOnXNG8hzNhqYSMMHJ+MwWWyTSjNUoP1jWHp1ZNmgB8TMH3Tl33mvoVb8uIj3umyIJLsAmYoCIqUCVMCN5WrW78Qi+AkeaGOkWFk3QbRmIWHpIZSURXDxhJVlJiYZ6kLEgeEjIRCBmxebhCTWlTJNaXLystGysVToPOAFJJjqSPNOXftSVbXPQjxrzVaFNzXvBonWJlonIVTJabAfjZ0Jxufl5GPntEHKjB7PIXtg6eYHywJn3hTdijjXUain94KjfCfg1hM3AZRR4N16VMXBrsDVYDCjOIMmGFsAab8rdY7+kIw0BgtRgL1DKJeuNZdQ9f5RAGGfOQfZxexj7t37RkjNp4rPDIHOJVyPBF+XHKsnQk4SWRBl8Wot74WtkBqidQggbyj2vW1WEFG6JfUZ8UxhVzOmAUdKTYZ3yxR2QwIIAQdA9YgiRBZWyCguiOER9y9IauiyGqR0EayVLiEVwmXmF5+Z2jfohj8i1q8ybRahCBAXZBCBUqLgAACQFzp5M/o5wzCDcCJZEOF9EzggM7NEd18c1Q85gPBldtg6mwB1N+hzyTSFp5jWM+WpCRBEBAjIaUxJI80o3s6vDYJ7gNXuAUfOacvsLvLhNIMaMwh8GccsXjtuiK+wkxZ/kVdOCzoCeAOn+N7H1rU1YT35MgAWY9yD5wMWI7j7G976bSh8LxDx2jI3IJRAnJ+RQQIU7gABnLd3vKSyMAd71mq7HgV3AJ+Sxh5Bz5O0z/gbTiNT8DxQssrrv7Uyx9Y7q6BQVUoIGonF/FfoC/RqwVHlviCRSABDvLaCUfZlz1cNENn6adNTz+AF8v8KWQAFL+QMkpCthFkpvvq7+2/to6AIBhyvPdrUr3g1XwBEJPMeP/98SxWWvs3nHIhgNnsY1RWVyw+Guh5IZLgj9WzPi/iEk9gPPGLAni3aRlsqlGQ9jP4z9Q/s/xi3dw486abm6Bqi2l3qu9e9tQsdVMdG4zbVYqp5wJcBSA2W6sNmkwxuNk+nw3r4MFi/4EkTAhiRFk70jkqNDiWbDK65OLIn0s0wD/ucAp3XwVSsSNBAqjFUIXwFE0MihZQ6utQYV2oR+tShO7Ad6bswY3xd7qe0VrVxK9ZjueQy4TPnF8MCQGjoxSugSFgFMV4LiVwgsn/i+gXZ2FzplAduxnn0/OlW0uqf+M64MRPqzwrl+PnpKQSaXS49Ui7n2/ctFtHtAtiprzxq6WniwESvW5yUG1Xx6/8Hx8NKELwKZK15pV/EvXvm9ZMlx0aKUO98iUPaWvst/n8ZbOmkvGhcOQRWf5zj9dk9cfpad5oHN3Rns/wsuvy2puxz1Ziu96Q7/SOWoROzvNzFo5Z5+1BDej3OjQ/XymEkW9jr0em5g5SdX8VC2gf9xJb/RWCC5bIKWDgWcYf+K9Kje3zbQBh/F448wMLoICeUyJ330nXlPmawiRT/sblG4vWrbErgQaMzYbZcwbhSaNrwH+Tqa04jqrd3JZTvwbFxHFSVMAv5UZdEq+tQUupcis/5+MZNsxk9b8TPa7cMqdzzrh9FtD5v+vPACvJy7nDT69IP/Yx6EywGdTFsD5iU7bqkovJogzTjQm3iFTyp4jV4bjVKdcnv5/JrhokmpnGAIA4D/AXYCfVgoBXnrDkCqqCHRG529HeYB51Jy1z6nlW/gnVmzyxmVHxnQrxXxelcI0yN85udPl+//t2rzKzA+oluPTNjp6qY1PVduFVdo8ya+8E6p8KOZR+bLj6Vju9oi5dar0erTS8Z1x3/IITU3vyDRLiZWBZVH6CbqURTeLptD3pEPIR4W4QlHfTnRJzZBRJ8MlI8LmmEXLAdAxsqIYbSDGTt65GfF0cUL6aQQ= "Kerbal Space Program"

<!-- links to add-ons/mods -->
[all]: http://forum.kerbalspaceprogram.com/index.php?/topic/155858-*/ "AllYAll"
[bdb]: http://forum.kerbalspaceprogram.com/index.php?/topic/122020-*/ "Bluedog Design Bureau"
[bgp]: http://forum.kerbalspaceprogram.com/index.php?/topic/88777-*/ "BackgroundProcessing"
[bgr]: https://github.com/KSP-RO/TacLifeSupport/wiki "Background Resources"
[crp]: https://forum.kerbalspaceprogram.com/index.php?/topic/166314-*/ "Community Resource Pack"
[jdf]: https://forum.kerbalspaceprogram.com/index.php?/topic/170919-*/ "Jatwaa Demolitions Co"
[mm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"
[mml]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"
[rla]: https://forum.kerbalspaceprogram.com/index.php?/topic/175512-*/ "RLA Reborn"
[sfc]: https://forum.kerbalspaceprogram.com/index.php?/topic/187776-*/ "Solid Fuel Cells"
[smx]: http://forum.kerbalspaceprogram.com/index.php?/topic/130325-105-*/ "Stockalike Mining Extension (SMX)"
[twk]: https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*/ "TweakScale"
[us1]: https://forum.kerbalspaceprogram.com/index.php?/topic/68043-*/ "Universal Storage"
[us2]: https://forum.kerbalspaceprogram.com/index.php?/topic/177385-*/ "Univeral Storage II"

[HBIFC]: https://github.com/zer0Kerbal/HotBeverageIrradiated "Hot Beverages Irradiated"
[GPO]: https://forum.kerbalspaceprogram.com/index.php?/topic/207732-*/ "GPO SpeedPump (GPO)"
[ODFC]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-*/ "On Demand Fuel Cells"

<!-- financial support -->
[PAYPAL:img]: https://img.shields.io/badge/Buy%20me%20some%20-LFO-BADA55?style=for-the-badge&logo=paypal&labelColor=FFDD00/ "PayPal"
[PAYPAL:url]: https://www.paypal.com/donate?hosted_button_id=DC22YHMEJREKL/ "PayPal"
[PATREON:img]: https://img.shields.io/badge/Patreon%20-Patreonize-FF424D?style=for-the-badge&logo=patreon/ "Patreon"
[PATREON:url]: https://www.patreon.com/bePatron?u=23390503/ "Patreon"
[GSPONS:img]: https://img.shields.io/badge/Github%20-Sponsor-EA4AAA?style=for-the-badge&logo=githubsponsors/ "Github Sponsors"
[GSPONS:url]: https://github.com/sponsors/zer0Kerbal/ "Github Sponsors"
[BMCC:img]: https://img.shields.io/badge/Buy%20Me%20a%20-Snack!-FFDD00?style=for-the-badge&logo=buymeacoffee/ "Buy Me A Snack"
[BMCC:url]: https://buymeacoffee.com/zer0Kerbal/ "Buy Me A Snack"

<!-- Localization -->
[lreadme]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/readme.md "Localization Readme"
[qstart]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/quickstart.md "Quickstart"
[EN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/EN.png "English"
[BR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/BR.png "Português Brasil"
[CN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/CH.png "中文"
[DE]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/DE.png "Deutsch"
[ES]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/ES.png "Español"
[FR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/FR.png "Français"
[IT]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/IT.png "Italiano"
[JA]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/JA.png "日本語"
[KO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/KO.png "한국어"
[MX]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/MX.png "Mexicano Español"
[NL]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/NL.png "Dutch"
[NO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/NO.png "Norsk"
[PO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/PO.png "Polski"
[RU]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/RU.png "Русский"
[SW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/SW.png "Svenska"
[TR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/TR.png "Türk"
[TW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/TW.png "国语"

[curseforge]: https://www.curseforge.com/members/zer0kerbal/projects
[reddit]: https://www.reddit.com/user/zer0Kerbal
[twitch]: https://www.twitch.tv/zer0kerbal
[twitter]: https://twitter.com/zer0Kerbal
[youtube]: https://www.youtube.com/@zer0Kerbal

[orum]: https://forum.kerbalspaceprogram.com/index.php?/profile/102159-*/ "Orum"
[4x4cheesecake]: https://forum.kerbalspaceprogram.com/index.php?/profile/42741-*/ "4x4cheesecake"
[zer0Kerbal]: https://forum.kerbalspaceprogram.com/index.php?/profile/190933-*/ "zer0Kerbal"

---

#### Connect with me

Track progress: issues [here][MOD:issue] and projects [here](https://github.com/zer0Kerbal/OnDemandFuelCells/projects/) along with **[The Short List](https://github.com/users/zer0Kerbal/projects/27)**

[<img align="left" alt="zer0Kerbal | kerbalspaceprogram.com" width="32px" src="https://cdn.icon-icons.com/icons2/1381/PNG/32/kerbalspaceprogram_93898.png" />][zer0Kerbal] [<img align="left" alt="zer0Kerbal | CurseForge" width="32px" src="https://cdn.jsdelivr.net/npm/simple-icons@v3/icons/curseforge.svg" />][curseforge] [<img align="left" alt="zer0Kerbal | reddit" width="32px" src="https://cdn.icon-icons.com/icons2/1945/PNG/512/iconfinder-reddit-4661631_122483.png" />][reddit] [<img align="left" alt="zer0Kerbal | Patreon" width="32px" src="https://cdn.icon-icons.com/icons2/2429/PNG/512/patreon_logo_icon_147253.png" />][PATREON:url] [<img align="left" alt="zer0Kerbal | YouTube" width="32px" src="https://cdn.icon-icons.com/icons2/836/PNG/512/Youtube_icon-icons.com_66802.png" />][youtube] [<img align="left" alt="zer0Kerbal | Twitch" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/twitch_logo_icon_170383.png" />][twitch] [<img align="left" alt="zer0Kerbal | PayPal" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/paypal_logo_icon_168055.png" />][PAYPAL:url] [<img align="left" alt="zer0Kerbal | Buy Me a Coffee" width="32px" src="https://www.buymeacoffee.com/assets/img/bmc-meta-new/new/favicon.ico" />][BMCC:url] [<img align="left" alt="zer0Kerbal | Twitter" width="32px" src="https://cdn.icon-icons.com/icons2/836/PNG/32/Twitter_icon-icons.com_66803.png" />][twitter]

<!-- footnotes -->
[^1]: this isn't a mod. ;P
[^2]: ***may*** work on other versions (YMMV)
[^3]: *Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date!*