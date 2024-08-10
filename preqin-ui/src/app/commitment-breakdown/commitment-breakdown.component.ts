import { CommonModule } from '@angular/common';
import { ChangeDetectorRef, Component, Input, SimpleChanges } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { MatTabsModule } from '@angular/material/tabs';

@Component({
  selector: 'app-commitment-breakdown',
  standalone: true,
  imports: [CommonModule, MatTabsModule, MatTableModule],
  templateUrl: './commitment-breakdown.component.html',
  styleUrl: './commitment-breakdown.component.css'
})
export class CommitmentBreakdownComponent {
  @Input() investor: any;
  filteredCommitments: any[] = [];
  displayedColumns: string[] = ['id', 'assetClass', 'amount'];

  constructor(private cdr: ChangeDetectorRef) {}

  ngOnChanges() {
      console.log('Investor data:', this.investor);
      this.filteredCommitments = this.investor.commitments || [];
      this.cdr.detectChanges(); // Force change detection
  }

  filterCommitments(assetClass: string) {
    if (this.investor && this.investor.commitments) {
      if (assetClass === 'All') {
        this.filteredCommitments = this.investor.commitments;
      } else {
        this.filteredCommitments = this.investor.commitments.filter((c: any) => c.assetClass === assetClass);
      }
    }
  }
}
