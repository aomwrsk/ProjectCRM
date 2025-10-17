document.addEventListener("DOMContentLoaded", async () => {
    try {
        const res = await fetch("/Dashboard/GetSalesData");
        const data = await res.json();

        const labels = data.map(x => x.Month);
        const totals = data.map(x => x.Total);

        const ctx = document.getElementById("salesChart").getContext("2d");

        new Chart(ctx, {
            type: "bar",
            data: {
                labels: labels,
                datasets: [{
                    label: "ยอดขาย (บาท)",
                    data: totals,
                    borderWidth: 1,
                    backgroundColor: "rgba(0, 102, 204, 0.7)",
                    borderColor: "rgba(0, 102, 204, 1)",
                }]
            },
            options: {
                responsive: true,
                scales: {
                    y: {
                        beginAtZero: true,
                        title: {
                            display: true,
                            text: "ยอดขาย (บาท)"
                        }
                    },
                    x: {
                        title: {
                            display: true,
                            text: "เดือน"
                        }
                    }
                },
                plugins: {
                    legend: {
                        display: false
                    },
                    title: {
                        display: false
                    }
                }
            }
        });

    } catch (err) {
        console.error("⚠️ Error loading chart:", err);
    }
});
