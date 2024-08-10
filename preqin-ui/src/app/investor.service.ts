import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InvestorService {
  private investorApiUrl = 'https://localhost:7135/api/investor';
  private commitmentsApiUrl = 'https://localhost:7135/api/commitment';

  constructor(private http: HttpClient) {}

  getInvestors(): Observable<any[]> {
    return this.http.get<any[]>(this.investorApiUrl);
  }

  getCommitmentsByInvestorId(investorId: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.commitmentsApiUrl}/by-investor/${investorId}`);
  }
}
