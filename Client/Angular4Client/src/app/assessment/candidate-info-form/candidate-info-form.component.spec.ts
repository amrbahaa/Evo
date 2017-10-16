import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CandidateInfoFormComponent } from './candidate-info-form.component';

describe('CandidateInfoFormComponent', () => {
  let component: CandidateInfoFormComponent;
  let fixture: ComponentFixture<CandidateInfoFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CandidateInfoFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CandidateInfoFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
