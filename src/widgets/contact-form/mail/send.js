export const send = async (contact) => {
  let ebody = `
    <h1>Номер: </h1>${contact.phone}
    <br>
    <h1>Имя: </h1>${contact.name || '-'}
    <br>
    <h1>Сообщение: </h1>${contact.message || '-'}
    `

  const message = await Email.send({
    SecureToken: '339c8ec4-f6d1-4536-a646-a7f7cef2abeb', //add your token here
    To: 'cornelius.media5@gmail.com',
    From: 'cornelius.media5@gmail.com',
    Subject: `Заяка на звонок с corenelius.md ${contact.phone}`,
    Body: ebody
  })
  console.log({ message })
}