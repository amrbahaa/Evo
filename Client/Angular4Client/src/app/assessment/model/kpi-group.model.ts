import { KPI } from './kpi.model';

export class KpiGroup {
    Name: string;
    Description?: string;
    KPIs: KPI[];
}
