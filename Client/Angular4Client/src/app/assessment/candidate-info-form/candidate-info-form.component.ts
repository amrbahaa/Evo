import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs/Observable';

import { IPoistion } from './../model/position.model';
import { KpiService } from './../kpi.service';

@Component({
  selector: 'app-candidate-info-form',
  templateUrl: './candidate-info-form.component.html',
  styleUrls: ['./candidate-info-form.component.scss']
})
export class CandidateInfoFormComponent implements OnInit {
  candidateInfo: FormGroup;

  positionCtrl: FormControl;
  filteredPositions$: Observable<IPoistion[]>;
  positions: IPoistion[] = [];

  constructor(private dataService: KpiService, private fb: FormBuilder) {

    this.positionCtrl = new FormControl();

    this.filteredPositions$ = this.positionCtrl.valueChanges
      .startWith(null)
      .map(position => {
        return position ? this.filterPositions(position) : this.positions.slice();
      });

  }

  filterPositions(name: string) {
    return this.positions.filter(state =>
      state.Name.toLowerCase().indexOf(name.toLowerCase()) === 0);
  }

  ngOnInit() {
    this.candidateInfo = this.fb.group({
      name: ['candidate_name', Validators.required],
      position: 'candidate_position'
    });

    this.dataService.getWorkPositions().subscribe(positions => this.positions = positions);
  }

}
