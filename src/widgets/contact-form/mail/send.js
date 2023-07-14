export const send = async (contact) => {
  let ebody = `
    <h1>Номер: </h1>${contact.phone}
    <br>
    <h1>Имя: </h1>${contact.name || '-'}
    <br>
    <h1>Сообщение: </h1>${contact.name || '-'}
    `

  const message = await Email.send({
    SecureToken: '4ccadafe-75fb-4dea-b418-bd3f0ab5a041', //add your token here
    To: 'nikita.nedelko.job@gmail.com',
    From: 'nikita.nedelko.job@gmail.com',
    Subject: `Заяка на звонок с corenelius.md ${contact.phone}`,
    Body: ebody
  })

  if (message) alert(message)
}
