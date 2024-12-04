# Information System Design and Development for WOPA

## Overview
This project focuses on designing and developing an information system to streamline the operations of **WOPA**, a workspace management company. The system is aimed at enhancing efficiency, automating key processes, and improving client satisfaction by addressing business challenges identified during the analysis phase.

## About WOPA
**WOPA** is a workspace management company offering flexible, all-inclusive office solutions for startups and small to medium-sized enterprises. Located in Ra’anana, Israel, the company provides a variety of services, including workspace rentals, event coordination, and technical support.

### Key Challenges:
1. Manual and fragmented management processes (e.g., tenant onboarding, maintenance, and reservations).
2. Lack of integration between systems leading to inefficiencies and data duplication.
3. Limited automation causing delays and errors in daily operations.

## System Objectives
The system is designed to:
- Automate workflows like tenant onboarding, event management, and room reservations.
- Centralize data with role-based access to ensure security and efficiency.
- Provide analytical tools for operational insights and decision-making.

## Key Features
### Tenant Management
- Add, update, or delete tenant profiles.
- Automate tenant onboarding, including contract signing and account setup.
- Manage room reservation credits per tenant agreement.

### Maintenance Management
- Open and track maintenance tickets with real-time status updates.
- Automate notifications for unresolved or escalated issues.
- Allow tenants to attach descriptions and images for better issue reporting.

### Event Coordination
- Schedule events with integrated workflows for resource allocation.
- Automatically send invitations and collect RSVP responses.
- Generate reports on event participation and resource utilization.

### Room Reservations
- Interactive room booking system with availability filters.
- Restrict bookings based on tenant agreements and floor access.
- Provide confirmation notifications upon successful reservations.

### Data and Reporting
- Generate financial, operational, and tenant-related reports.
- Visual dashboards for quick insights into company performance.
- Integration with mapping tools for workspace allocation tracking.

## Design Process
### Analysis Phase
- Conducted interviews and surveys with stakeholders.
- Mapped existing workflows and identified pain points.
- Created BPMN diagrams to visualize process inefficiencies.

### Proposed Solution
The system integrates key functionalities, such as:
- Automated tenant onboarding with modular contract management.
- Maintenance ticketing system with priority levels and real-time tracking.
- Event management module for seamless planning and execution.
- Room reservation system with usage restrictions based on agreements.

### Tools and Technologies
- **Database**: SQL-based system for centralized data management.
- **Backend**: Developed using C#.
- **Frontend**: Responsive UI using WinForms.
- **Integration**: APIs for email notifications and calendar syncing.

## Implementation
- **Phase 1**: Tenant and maintenance management modules.
- **Phase 2**: Room reservations and event management modules.
- **Phase 3**: Analytical dashboards and reporting.

## How to Use
1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Install dependencies:
   ```bash
   pip install -r requirements.txt
   ```
3. Set up the database:
   ```bash
   python setup_db.py
   ```
4. Run the application:
   ```bash
   python app.py
   ```
5. Access the system through your browser:
   ```bash
   http://localhost:5000
   ```
## Authors
- **Maya Adar**
- **Adi Akriv**
- **Tamar Yosef Hay**
