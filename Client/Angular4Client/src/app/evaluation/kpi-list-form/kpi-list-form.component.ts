import { Component, OnInit } from '@angular/core';
import { KpiGroup } from '../model';
import { KpiService } from './../kpi.service';

@Component({
  selector: 'app-kpi-list-form',
  templateUrl: './kpi-list-form.component.html',
  styleUrls: ['./kpi-list-form.component.css']
})
export class KpiListFormComponent implements OnInit {

  kpiGroups: KpiGroup[];

  constructor(private service: KpiService) { }

  ngOnInit() {
    this.service.getKpiGroups().subscribe(kpiGroups => this.kpiGroups = kpiGroups);
  }

}
