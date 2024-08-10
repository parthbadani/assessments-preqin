import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommitmentBreakdownComponent } from './commitment-breakdown.component';

describe('CommitmentBreakdownComponent', () => {
  let component: CommitmentBreakdownComponent;
  let fixture: ComponentFixture<CommitmentBreakdownComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CommitmentBreakdownComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CommitmentBreakdownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
