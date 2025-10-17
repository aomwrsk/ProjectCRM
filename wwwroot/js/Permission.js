async function toggleActive(staffId, username, isActive) {
    try {
        const response = await fetch('/Customer/UpdateActive', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
                StaffId: staffId,
                Username: username,
                IsActive: isActive
            })
        });

        if (response.ok) {
            console.log(`✅ Updated ${username} (${staffId}) → ${isActive ? 'Y' : 'N'}`);
        } else {
            const error = await response.text();
            alert(`❌ Update failed: ${error}`);
        }
    } catch (err) {
        console.error("⚠️ Error while updating:", err);
        alert("เกิดข้อผิดพลาดในการอัปเดตข้อมูล");
    }
}
