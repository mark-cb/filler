import { Site } from "./site";

export interface Pump {
    pumpId: number;
    number: number;
    unLocked: boolean;
    siteId: number;
    site: Site;
}
