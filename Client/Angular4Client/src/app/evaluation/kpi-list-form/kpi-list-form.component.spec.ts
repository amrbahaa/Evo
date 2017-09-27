import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { KpiListFormComponent } from './kpi-list-form.component';

describe('KpiListFormComponent', () => {
  let component: KpiListFormComponent;
  let fixture: ComponentFixture<KpiListFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ KpiListFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(KpiListFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
