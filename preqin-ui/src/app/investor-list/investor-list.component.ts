import { Component } from '@angular/core';
import { InvestorService } from '../investor.service';
import { CommonModule } from '@angular/common';
import { MatTabsModule } from '@angular/material/tabs';
import { MatTableModule } from '@angular/material/table';
import { CommitmentBreakdownComponent } from '../commitment-breakdown/commitment-breakdown.component';
import { ChangeDetectorRef } from '@angular/core';

@Component({
  selector: 'app-investor-list',
  standalone: true,
  imports: [CommonModule, MatTabsModule, MatTableModule, CommitmentBreakdownComponent],
  templateUrl: './investor-list.component.html',
  styleUrl: './investor-list.component.css'
})
export class InvestorListComponent {
  investors: any[] = [];
  selectedInvestor: any = null;
  displayedColumns: string[] = ['id', 'name', 'type', 'dateAdded', 'address', 'totalCommitment'];

  constructor(private investorService: InvestorService,
    private cdr: ChangeDetectorRef
  ) {}

  ngOnInit() {
    this.loadInvestors();
  }

  loadInvestors() {
    this.investorService.getInvestors().subscribe(data => {
      this.investors = data;
    });
  }

  selectInvestor(investor: any) {
    this.selectedInvestor = investor;
    this.investorService.getCommitmentsByInvestorId(investor.id).subscribe(data => {
      this.selectedInvestor.commitments = data;
      this.cdr.detectChanges(); // Force change detection
    });
  }
}
